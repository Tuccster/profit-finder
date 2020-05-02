namespace ProfitFinderS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.nudBuyOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudMaxProfit = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMaxRequestDelay = new System.Windows.Forms.NumericUpDown();
            this.nudMinRequestDelay = new System.Windows.Forms.NumericUpDown();
            this.nudMinSearchIndex = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMaxSearchIndex = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nudMinSearchIndexGloves = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMaxSearchIndexGloves = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyOrderAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxProfit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRequestDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinRequestDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSearchIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSearchIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSearchIndexGloves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSearchIndexGloves)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewMain
            // 
            this.treeViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewMain.BackColor = System.Drawing.Color.White;
            this.treeViewMain.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewMain.Location = new System.Drawing.Point(12, 40);
            this.treeViewMain.Name = "treeViewMain";
            this.treeViewMain.PathSeparator = "/";
            this.treeViewMain.Size = new System.Drawing.Size(952, 376);
            this.treeViewMain.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(884, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBarMain
            // 
            this.progressBarMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarMain.Location = new System.Drawing.Point(12, 511);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(952, 16);
            this.progressBarMain.TabIndex = 2;
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProgress.AutoSize = true;
            this.labelProgress.BackColor = System.Drawing.Color.Transparent;
            this.labelProgress.Location = new System.Drawing.Point(12, 530);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(148, 17);
            this.labelProgress.TabIndex = 3;
            this.labelProgress.Text = "No search in progress";
            // 
            // nudBuyOrderAmount
            // 
            this.nudBuyOrderAmount.DecimalPlaces = 2;
            this.nudBuyOrderAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudBuyOrderAmount.Location = new System.Drawing.Point(8, 25);
            this.nudBuyOrderAmount.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.nudBuyOrderAmount.Name = "nudBuyOrderAmount";
            this.nudBuyOrderAmount.Size = new System.Drawing.Size(72, 22);
            this.nudBuyOrderAmount.TabIndex = 5;
            this.nudBuyOrderAmount.ThousandsSeparator = true;
            this.nudBuyOrderAmount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "buy order amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "max profit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "min request delay (ms)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "max request delay (ms)";
            // 
            // nudMaxProfit
            // 
            this.nudMaxProfit.DecimalPlaces = 2;
            this.nudMaxProfit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMaxProfit.Location = new System.Drawing.Point(8, 53);
            this.nudMaxProfit.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.nudMaxProfit.Name = "nudMaxProfit";
            this.nudMaxProfit.Size = new System.Drawing.Size(72, 22);
            this.nudMaxProfit.TabIndex = 13;
            this.nudMaxProfit.ThousandsSeparator = true;
            this.nudMaxProfit.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nudMaxRequestDelay);
            this.groupBox1.Controls.Add(this.nudMinRequestDelay);
            this.groupBox1.Controls.Add(this.nudBuyOrderAmount);
            this.groupBox1.Controls.Add(this.nudMaxProfit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 83);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Search Settings";
            // 
            // nudMaxRequestDelay
            // 
            this.nudMaxRequestDelay.Location = new System.Drawing.Point(204, 53);
            this.nudMaxRequestDelay.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.nudMaxRequestDelay.Name = "nudMaxRequestDelay";
            this.nudMaxRequestDelay.Size = new System.Drawing.Size(72, 22);
            this.nudMaxRequestDelay.TabIndex = 15;
            this.nudMaxRequestDelay.ThousandsSeparator = true;
            this.nudMaxRequestDelay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // nudMinRequestDelay
            // 
            this.nudMinRequestDelay.Location = new System.Drawing.Point(204, 25);
            this.nudMinRequestDelay.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.nudMinRequestDelay.Name = "nudMinRequestDelay";
            this.nudMinRequestDelay.Size = new System.Drawing.Size(72, 22);
            this.nudMinRequestDelay.TabIndex = 14;
            this.nudMinRequestDelay.ThousandsSeparator = true;
            this.nudMinRequestDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMinSearchIndex
            // 
            this.nudMinSearchIndex.Location = new System.Drawing.Point(10, 21);
            this.nudMinSearchIndex.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.nudMinSearchIndex.Name = "nudMinSearchIndex";
            this.nudMinSearchIndex.Size = new System.Drawing.Size(72, 22);
            this.nudMinSearchIndex.TabIndex = 16;
            this.nudMinSearchIndex.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "min search index";
            // 
            // nudMaxSearchIndex
            // 
            this.nudMaxSearchIndex.Location = new System.Drawing.Point(10, 51);
            this.nudMaxSearchIndex.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.nudMaxSearchIndex.Name = "nudMaxSearchIndex";
            this.nudMaxSearchIndex.Size = new System.Drawing.Size(72, 22);
            this.nudMaxSearchIndex.TabIndex = 18;
            this.nudMaxSearchIndex.Value = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "max search index";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(12, 17);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(166, 17);
            this.labelResults.TabIndex = 15;
            this.labelResults.Text = "Search Results (0 found)";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(884, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(811, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Generate with color";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // nudMinSearchIndexGloves
            // 
            this.nudMinSearchIndexGloves.Location = new System.Drawing.Point(6, 22);
            this.nudMinSearchIndexGloves.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.nudMinSearchIndexGloves.Name = "nudMinSearchIndexGloves";
            this.nudMinSearchIndexGloves.Size = new System.Drawing.Size(72, 22);
            this.nudMinSearchIndexGloves.TabIndex = 20;
            this.nudMinSearchIndexGloves.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "min search index";
            // 
            // nudMaxSearchIndexGloves
            // 
            this.nudMaxSearchIndexGloves.Location = new System.Drawing.Point(6, 52);
            this.nudMaxSearchIndexGloves.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.nudMaxSearchIndexGloves.Name = "nudMaxSearchIndexGloves";
            this.nudMaxSearchIndexGloves.Size = new System.Drawing.Size(72, 22);
            this.nudMaxSearchIndexGloves.TabIndex = 22;
            this.nudMaxSearchIndexGloves.Value = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "max search index";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudMinSearchIndex);
            this.groupBox2.Controls.Add(this.nudMaxSearchIndex);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(453, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 82);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weapon Skins";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.nudMinSearchIndexGloves);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.nudMaxSearchIndexGloves);
            this.groupBox3.Location = new System.Drawing.Point(664, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 82);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Glove Skins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 556);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBarMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeViewMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(760, 603);
            this.Name = "Form1";
            this.Text = "Profit Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyOrderAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxProfit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRequestDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinRequestDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSearchIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSearchIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSearchIndexGloves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSearchIndexGloves)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.NumericUpDown nudBuyOrderAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudMaxProfit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudMaxRequestDelay;
        private System.Windows.Forms.NumericUpDown nudMinRequestDelay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMaxSearchIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMinSearchIndex;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown nudMinSearchIndexGloves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaxSearchIndexGloves;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

