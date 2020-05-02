using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProfitFinderS
{
    // References and variables that will be passed to search thread
    public class SearchConfiguration
    {
        public TreeView treeView;
        public ProgressBar progressBar;
        public Label labelProgress;
        public Label labelResults;

        public float buyOrderAmount;
        public float maxProfit;
        public int minRequestDelay;
        public int maxRequestDelay;
        public int minSearchIndex;
        public int maxSearchIndex;
        public int minSearchIndexGloves;
        public int maxSearchIndexGloves;

        public bool useColor;
    }
}
