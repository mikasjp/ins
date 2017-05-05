namespace InertialNavigationSystem_Demo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.FilterSelector = new System.Windows.Forms.ToolStripComboBox();
            this.fIRFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphaBetaFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smartAlphaBetaFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgressIndicator = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Chart1 = new ZedGraph.ZedGraphControl();
            this.WaitingScreen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnSelector = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.WaitingScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.ColumnSelector,
            this.toolStripSeparator2,
            this.ProgressIndicator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 25);
            this.toolStripButton1.Text = "File";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.importDataToolStripMenuItem.Text = "Import data";
            this.importDataToolStripMenuItem.Click += new System.EventHandler(this.importDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterSelector,
            this.toolStripSeparator3,
            this.fIRFilterToolStripMenuItem,
            this.alphaBetaFilterToolStripMenuItem,
            this.smartAlphaBetaFilterToolStripMenuItem});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(77, 25);
            this.toolStripButton2.Text = "Filtering";
            // 
            // FilterSelector
            // 
            this.FilterSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterSelector.Items.AddRange(new object[] {
            "None",
            "FIR Filter",
            "Alpha Beta Filter",
            "Smart Alpha Beta Filter"});
            this.FilterSelector.MergeIndex = 1;
            this.FilterSelector.Name = "FilterSelector";
            this.FilterSelector.Size = new System.Drawing.Size(217, 28);
            this.FilterSelector.SelectedIndexChanged += new System.EventHandler(this.FilterSelector_SelectedIndexChanged);
            // 
            // fIRFilterToolStripMenuItem
            // 
            this.fIRFilterToolStripMenuItem.Name = "fIRFilterToolStripMenuItem";
            this.fIRFilterToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.fIRFilterToolStripMenuItem.Text = "FIR Filter";
            this.fIRFilterToolStripMenuItem.Click += new System.EventHandler(this.fIRFilterToolStripMenuItem_Click);
            // 
            // alphaBetaFilterToolStripMenuItem
            // 
            this.alphaBetaFilterToolStripMenuItem.Name = "alphaBetaFilterToolStripMenuItem";
            this.alphaBetaFilterToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.alphaBetaFilterToolStripMenuItem.Text = "Alpha Beta Filter";
            this.alphaBetaFilterToolStripMenuItem.Click += new System.EventHandler(this.alphaBetaFilterToolStripMenuItem_Click);
            // 
            // smartAlphaBetaFilterToolStripMenuItem
            // 
            this.smartAlphaBetaFilterToolStripMenuItem.Name = "smartAlphaBetaFilterToolStripMenuItem";
            this.smartAlphaBetaFilterToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.smartAlphaBetaFilterToolStripMenuItem.Text = "Smart Alpha Beta Filter";
            this.smartAlphaBetaFilterToolStripMenuItem.Click += new System.EventHandler(this.smartAlphaBetaFilterToolStripMenuItem_Click);
            // 
            // ProgressIndicator
            // 
            this.ProgressIndicator.Name = "ProgressIndicator";
            this.ProgressIndicator.Size = new System.Drawing.Size(100, 25);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "CSV Files|*.csv";
            this.openFileDialog.Title = "Select data file";
            // 
            // Chart1
            // 
            this.Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart1.Location = new System.Drawing.Point(0, 28);
            this.Chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Chart1.Name = "Chart1";
            this.Chart1.ScrollGrace = 0D;
            this.Chart1.ScrollMaxX = 0D;
            this.Chart1.ScrollMaxY = 0D;
            this.Chart1.ScrollMaxY2 = 0D;
            this.Chart1.ScrollMinX = 0D;
            this.Chart1.ScrollMinY = 0D;
            this.Chart1.ScrollMinY2 = 0D;
            this.Chart1.Size = new System.Drawing.Size(732, 425);
            this.Chart1.TabIndex = 1;
            // 
            // WaitingScreen
            // 
            this.WaitingScreen.Controls.Add(this.label1);
            this.WaitingScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WaitingScreen.Location = new System.Drawing.Point(0, 28);
            this.WaitingScreen.Name = "WaitingScreen";
            this.WaitingScreen.Size = new System.Drawing.Size(732, 425);
            this.WaitingScreen.TabIndex = 2;
            this.WaitingScreen.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 425);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please wait...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColumnSelector
            // 
            this.ColumnSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnSelector.Name = "ColumnSelector";
            this.ColumnSelector.Size = new System.Drawing.Size(121, 28);
            this.ColumnSelector.SelectedIndexChanged += new System.EventHandler(this.ColumnSelector_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 25);
            this.toolStripLabel1.Text = "CSV Column:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(280, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.WaitingScreen);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form1";
            this.Text = "Inertial Navigation System Demo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.WaitingScreen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private ZedGraph.ZedGraphControl Chart1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripComboBox FilterSelector;
        private System.Windows.Forms.ToolStripMenuItem fIRFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphaBetaFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smartAlphaBetaFilterToolStripMenuItem;
        private System.Windows.Forms.Panel WaitingScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripProgressBar ProgressIndicator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox ColumnSelector;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

