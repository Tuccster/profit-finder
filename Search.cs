using System;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace ProfitFinderS
{
    public class Search
    {
        // Steam return percentage on market sales
        private const float precentReturn = 86.97f;

        // All XPath constant variables used for locating respective data
        private const string websiteBaseWeapons = "https://csgostash.com/skin/";
        private const string websiteBaseGloves = "https://csgostash.com/glove/";
        private const string xPathTitle = "/html/head/title";
        private const string xPathWear = "//div[@id='prices']/div[@class='btn-group-sm btn-group-justified']";
        private const string xPathSpecification = "/html/body/div[2]/div[3]/div[2]/div/div[1]/div[1]/a[1]/div";
        private const string xPathSpecificationGloves = "/html/body/div[2]/div[4]/div[2]/div/div[1]/div[1]/div[1]";
        private const string xPathOffsetPrice = "//span[@class='pull-right']";
        private const string xPathOffsetStatTrak = "//span[@class='pull-left price-details-st']";
        private const string xPathOffsetSouvenir = "//span[@class='pull-left price-details-souv']";
        private const string xPathOffsetCondition = "//span[@class='pull-left']";
        private const string xPathOffsetLink = "//a";

        // Local variables
        private float minPrice;
        private float maxPrice;
        private int resultNumber;

        public void Start(SearchConfiguration sc)
        {
            // Exit search operation if there is a problem with some sc values
            if (!CheckValues(sc)) return;

            // Setup local variables
            minPrice = sc.buyOrderAmount * 100 / precentReturn;
            maxPrice = (sc.buyOrderAmount + sc.maxProfit) * 100 / precentReturn;
            resultNumber = 0;

            // Setup various UI elements
            sc.progressBar.Invoke((Action)delegate {
                sc.progressBar.Minimum = sc.minSearchIndex;
                sc.progressBar.Maximum = sc.maxSearchIndex;
            });
            sc.labelResults.Invoke((Action)delegate {
                sc.labelResults.Text = $"Results ({minPrice:c2} - {maxPrice:c2)}) | Found ({resultNumber})";
            });
            sc.treeView.Invoke((Action)delegate {
                sc.treeView.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(OpenWebpage);
            });

            // Iterate through all the specified website indexes for weapons if specified
            if (sc.maxSearchIndex > 0)
                for (int i = sc.minSearchIndex; i < sc.maxSearchIndex; i++)
                    ProcessWebpageAtIndex(sc, websiteBaseGloves, i, xPathSpecification);

            // Setup progress bar for glove search
            sc.progressBar.Invoke((Action)delegate {
                sc.progressBar.Minimum = sc.minSearchIndexGloves;
                sc.progressBar.Maximum = sc.maxSearchIndexGloves;
            });

            // Iterate through all the specified website indexes for gloves
            if (sc.maxSearchIndexGloves > 0)
                for (int i = sc.minSearchIndexGloves; i < sc.maxSearchIndexGloves; i++)
                    ProcessWebpageAtIndex(sc, websiteBaseGloves, i, xPathSpecificationGloves);

            // Update UI for completed status
            sc.progressBar.Invoke((Action)delegate{sc.progressBar.Value = sc.minSearchIndexGloves;});
            sc.labelProgress.Invoke((Action)delegate{sc.labelProgress.Text = "Complete";});
        }

        private void ProcessWebpageAtIndex(SearchConfiguration sc, string websiteBase, int index, string xPathSpec)
        {
            // Delay thread to keep from spamming the website with requests
            Random random = new Random();
            Thread.Sleep(random.Next(sc.minRequestDelay, sc.maxRequestDelay));

            // Get HTML and continue to next page if this on doesn't exist
            HtmlAgilityPack.HtmlDocument document = new HtmlWeb().Load(websiteBase + index);
            if (GetInnerText(document.DocumentNode, xPathTitle) == "Not Found") return;

            // Get the name of the currect skin
            string skinName = GetInnerText(document.DocumentNode, xPathTitle);
            skinName = skinName.Remove(skinName.Length - 14);

            // Get all the skin quality containers
            HtmlNodeCollection nodeCollection = document.DocumentNode.SelectNodes(xPathWear);

            // Iterate through each quality container
            foreach (HtmlNode node in nodeCollection)
            {
                // Get string from price location and attempt to parse it
                string priceString = GetInnerText(node, node.XPath + xPathOffsetPrice);
                if (priceString[0] != '$') continue;
                float.TryParse(priceString.Remove(0, 1), out float price);

                // Check if the skin's price fits the criteria
                if (price > minPrice && price < maxPrice)
                {
                    // Compile node name
                    string variant = "";
                    variant = $"{GetInnerText(node, node.XPath + xPathOffsetStatTrak)} ";
                    variant = $"{GetInnerText(node, node.XPath + xPathOffsetSouvenir)} ";
                    string completeSkinName = $"{skinName} ({variant}{GetInnerText(node, node.XPath + xPathOffsetCondition)})";

                    // Create and deploy tree node
                    TreeNode treeNode = new TreeNode(completeSkinName);
                    treeNode.Nodes.Add($"price: {priceString}");
                    treeNode.Nodes.Add($"profit: {price * (precentReturn / 100) - sc.buyOrderAmount:c2}");
                    treeNode.Nodes.Add(GetAttributeValue(node, node.XPath + xPathOffsetLink, "href"));
                    if (sc.useColor)
                        treeNode.ForeColor = GetColor(GetAttributeValue(node, xPathSpec, "class"));
                    if (treeNode != null)
                        sc.treeView.Invoke((Action)delegate { sc.treeView.Nodes.Add(treeNode); });

                    // Iterate result number to be updated in UI later
                    resultNumber++;
                }
            }

            // Update UI with post-cycle information
            sc.progressBar.Invoke((Action)delegate { sc.progressBar.Value = index; });
            sc.labelProgress.Invoke((Action)delegate
            {
                float min = index - sc.minSearchIndex;
                float max = sc.maxSearchIndex - sc.minSearchIndex;
                sc.labelProgress.Text = $"({min / max * 100:n2}%) {min} / {max}";
            });
            sc.labelResults.Invoke((Action)delegate {
                sc.labelResults.Text = $"Results ({minPrice:c2} - {maxPrice:c2}) | Found ({resultNumber})";
            });
        }

        // Get inner text of node if the node exists
        private string GetInnerText(HtmlNode node, string xPath)
        {
            if (node.SelectSingleNode(xPath) != null)
                return node.SelectSingleNode(xPath).InnerText;
            return string.Empty;
        }

        // Get value of attribute if the node exists
        private string GetAttributeValue(HtmlNode node, string xPath, string attribute)
        {
            if (node.SelectSingleNode(xPath) != null)
                return node.SelectSingleNode(xPath).Attributes[attribute].Value.ToString();
            return string.Empty;
        }

        // Check to make sure min max values are ready for comparison
        private bool CheckValues(SearchConfiguration sc)
        {
            if (sc.minRequestDelay > sc.maxRequestDelay)
            {
                MessageBox.Show("minRequestDelay must be greater than maxRequestDelay", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (sc.minSearchIndex > sc.maxSearchIndex)
            {
                MessageBox.Show("(Weapon Skins) minSearchIndex must be greater than maxSearchIndex", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (sc.minSearchIndexGloves > sc.maxSearchIndexGloves)
            {
                MessageBox.Show("(Glove Skins) minSearchIndex must be greater than maxSearchIndex", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Subscribed to the NodeMouseDoubleClick event
        private void OpenWebpage(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Contains("https://steamcommunity.com/"))
                Process.Start(e.Node.Text);
        }

        // Gets color based on attribute value
        private Color GetColor(string className)
        {
            switch (className)
            {
                case "quality color-consumer":
                    return ColorTranslator.FromHtml("#b0c3d8");
                case "quality color-industrial":
                    return ColorTranslator.FromHtml("#6098d7");
                case "quality color-milspec":
                    return ColorTranslator.FromHtml("#4e6afc");
                case "quality color-restricted":
                    return ColorTranslator.FromHtml("#8949fb");
                case "quality color-classified":
                    return ColorTranslator.FromHtml("#d230e3");
                case "quality color-covert":
                    return ColorTranslator.FromHtml("#ea4a4e");
                case "quality color-contraband":
                    return ColorTranslator.FromHtml("#fead45");
                default:
                    return Color.Black;
            }
        }
    }
}
