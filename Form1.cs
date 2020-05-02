using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitFinderS
{
    public partial class Form1 : Form
    {
        Thread searchThread = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Don't create new thread if one exists already
            treeViewMain.Nodes.Clear();
            if (searchThread != null && searchThread.IsAlive) return;

            // References and variables to be passes to search thread
            SearchConfiguration searchConfig = new SearchConfiguration();
            searchConfig.treeView = treeViewMain;
            searchConfig.progressBar = progressBarMain;
            searchConfig.labelProgress = labelProgress;
            searchConfig.labelResults = labelResults;
            searchConfig.buyOrderAmount = (float)nudBuyOrderAmount.Value;
            searchConfig.maxProfit = (float)nudMaxProfit.Value;
            searchConfig.minRequestDelay = (int)nudMinRequestDelay.Value;
            searchConfig.maxRequestDelay = (int)nudMaxRequestDelay.Value;
            searchConfig.minSearchIndex = (int)nudMinSearchIndex.Value;
            searchConfig.maxSearchIndex = (int)nudMaxSearchIndex.Value;
            searchConfig.minSearchIndexGloves = (int)nudMinSearchIndexGloves.Value;
            searchConfig.maxSearchIndexGloves = (int)nudMaxSearchIndexGloves.Value;
            searchConfig.useColor = checkBox1.Checked;

            // Create a new search thread
            Search search = new Search();
            searchThread = new Thread(unused => search.Start(searchConfig));
            searchThread.SetApartmentState(ApartmentState.STA);
            searchThread.Start();
            while (searchThread.IsAlive) Application.DoEvents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Don't try to abort if no search thread exists
            if (searchThread != null) searchThread.Abort();

            // Set progress bar and coresponding label
            progressBarMain.Value = progressBarMain.Minimum;
            labelProgress.Text = "Search stopped";
        }
    }
}
