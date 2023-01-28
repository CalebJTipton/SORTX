namespace SORTX
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceBrowseDirectory_btn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.sourceDirectoryPath_txt = new System.Windows.Forms.TextBox();
            this.primarySortType_cb = new System.Windows.Forms.ComboBox();
            this.primarySortType_txt = new System.Windows.Forms.Label();
            this.sourceDirectory_lbl = new System.Windows.Forms.Label();
            this.secondarySortType_lbl = new System.Windows.Forms.Label();
            this.secondarySortType_cb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sortxMethod_lbl = new System.Windows.Forms.Label();
            this.sortxMethod_cb = new System.Windows.Forms.ComboBox();
            this.outputDirectory_lbl = new System.Windows.Forms.Label();
            this.outputDirectoryPath_txt = new System.Windows.Forms.TextBox();
            this.outputDirectoryBrowse_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceBrowseDirectory_btn
            // 
            this.sourceBrowseDirectory_btn.Location = new System.Drawing.Point(506, 222);
            this.sourceBrowseDirectory_btn.Name = "sourceBrowseDirectory_btn";
            this.sourceBrowseDirectory_btn.Size = new System.Drawing.Size(75, 23);
            this.sourceBrowseDirectory_btn.TabIndex = 0;
            this.sourceBrowseDirectory_btn.Text = "Browse";
            this.sourceBrowseDirectory_btn.UseVisualStyleBackColor = true;
            this.sourceBrowseDirectory_btn.Click += new System.EventHandler(this.browseDirectory_btn_Click);
            // 
            // sourceDirectoryPath_txt
            // 
            this.sourceDirectoryPath_txt.Location = new System.Drawing.Point(68, 223);
            this.sourceDirectoryPath_txt.Name = "sourceDirectoryPath_txt";
            this.sourceDirectoryPath_txt.Size = new System.Drawing.Size(432, 23);
            this.sourceDirectoryPath_txt.TabIndex = 1;
            // 
            // primarySortType_cb
            // 
            this.primarySortType_cb.FormattingEnabled = true;
            this.primarySortType_cb.Location = new System.Drawing.Point(251, 275);
            this.primarySortType_cb.Name = "primarySortType_cb";
            this.primarySortType_cb.Size = new System.Drawing.Size(156, 23);
            this.primarySortType_cb.TabIndex = 2;
            // 
            // primarySortType_txt
            // 
            this.primarySortType_txt.AutoSize = true;
            this.primarySortType_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.primarySortType_txt.Location = new System.Drawing.Point(251, 257);
            this.primarySortType_txt.Name = "primarySortType_txt";
            this.primarySortType_txt.Size = new System.Drawing.Size(78, 15);
            this.primarySortType_txt.TabIndex = 3;
            this.primarySortType_txt.Text = "First Sort By:";
            // 
            // sourceDirectory_lbl
            // 
            this.sourceDirectory_lbl.AutoSize = true;
            this.sourceDirectory_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sourceDirectory_lbl.Location = new System.Drawing.Point(68, 205);
            this.sourceDirectory_lbl.Name = "sourceDirectory_lbl";
            this.sourceDirectory_lbl.Size = new System.Drawing.Size(159, 15);
            this.sourceDirectory_lbl.TabIndex = 4;
            this.sourceDirectory_lbl.Text = "Source Files Path/Directory";
            this.sourceDirectory_lbl.Click += new System.EventHandler(this.sortDirectory_lbl_Click);
            // 
            // secondarySortType_lbl
            // 
            this.secondarySortType_lbl.AutoSize = true;
            this.secondarySortType_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secondarySortType_lbl.Location = new System.Drawing.Point(425, 257);
            this.secondarySortType_lbl.Name = "secondarySortType_lbl";
            this.secondarySortType_lbl.Size = new System.Drawing.Size(82, 15);
            this.secondarySortType_lbl.TabIndex = 5;
            this.secondarySortType_lbl.Text = "Then Sort By:";
            // 
            // secondarySortType_cb
            // 
            this.secondarySortType_cb.FormattingEnabled = true;
            this.secondarySortType_cb.Location = new System.Drawing.Point(425, 275);
            this.secondarySortType_cb.Name = "secondarySortType_cb";
            this.secondarySortType_cb.Size = new System.Drawing.Size(156, 23);
            this.secondarySortType_cb.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SORTX.Properties.Resources.sortx_logo;
            this.pictureBox1.Location = new System.Drawing.Point(168, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 112);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // sortxMethod_lbl
            // 
            this.sortxMethod_lbl.AutoSize = true;
            this.sortxMethod_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sortxMethod_lbl.Location = new System.Drawing.Point(68, 257);
            this.sortxMethod_lbl.Name = "sortxMethod_lbl";
            this.sortxMethod_lbl.Size = new System.Drawing.Size(96, 15);
            this.sortxMethod_lbl.TabIndex = 8;
            this.sortxMethod_lbl.Text = "SORTX Method:";
            // 
            // sortxMethod_cb
            // 
            this.sortxMethod_cb.FormattingEnabled = true;
            this.sortxMethod_cb.Location = new System.Drawing.Point(68, 275);
            this.sortxMethod_cb.Name = "sortxMethod_cb";
            this.sortxMethod_cb.Size = new System.Drawing.Size(156, 23);
            this.sortxMethod_cb.TabIndex = 9;
            // 
            // outputDirectory_lbl
            // 
            this.outputDirectory_lbl.AutoSize = true;
            this.outputDirectory_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputDirectory_lbl.Location = new System.Drawing.Point(68, 308);
            this.outputDirectory_lbl.Name = "outputDirectory_lbl";
            this.outputDirectory_lbl.Size = new System.Drawing.Size(160, 15);
            this.outputDirectory_lbl.TabIndex = 12;
            this.outputDirectory_lbl.Text = "Output Files Path/Directory";
            // 
            // outputDirectoryPath_txt
            // 
            this.outputDirectoryPath_txt.Location = new System.Drawing.Point(68, 326);
            this.outputDirectoryPath_txt.Name = "outputDirectoryPath_txt";
            this.outputDirectoryPath_txt.Size = new System.Drawing.Size(432, 23);
            this.outputDirectoryPath_txt.TabIndex = 11;
            // 
            // outputDirectoryBrowse_btn
            // 
            this.outputDirectoryBrowse_btn.Location = new System.Drawing.Point(506, 326);
            this.outputDirectoryBrowse_btn.Name = "outputDirectoryBrowse_btn";
            this.outputDirectoryBrowse_btn.Size = new System.Drawing.Size(75, 23);
            this.outputDirectoryBrowse_btn.TabIndex = 10;
            this.outputDirectoryBrowse_btn.Text = "Browse";
            this.outputDirectoryBrowse_btn.UseVisualStyleBackColor = true;
            this.outputDirectoryBrowse_btn.Click += new System.EventHandler(this.outputDirectoryBrowse_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 571);
            this.Controls.Add(this.outputDirectory_lbl);
            this.Controls.Add(this.outputDirectoryPath_txt);
            this.Controls.Add(this.outputDirectoryBrowse_btn);
            this.Controls.Add(this.sortxMethod_cb);
            this.Controls.Add(this.sortxMethod_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.secondarySortType_cb);
            this.Controls.Add(this.secondarySortType_lbl);
            this.Controls.Add(this.sourceDirectory_lbl);
            this.Controls.Add(this.primarySortType_txt);
            this.Controls.Add(this.primarySortType_cb);
            this.Controls.Add(this.sourceDirectoryPath_txt);
            this.Controls.Add(this.sourceBrowseDirectory_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "SORTX V0.0.1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sourceBrowseDirectory_btn;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox sourceDirectoryPath_txt;
        private ComboBox primarySortType_cb;
        private Label primarySortType_txt;
        private Label sourceDirectory_lbl;
        private Label secondarySortType_lbl;
        private ComboBox secondarySortType_cb;
        private PictureBox pictureBox1;
        private Label sortxMethod_lbl;
        private ComboBox sortxMethod_cb;
        private Label outputDirectory_lbl;
        private TextBox outputDirectoryPath_txt;
        private Button outputDirectoryBrowse_btn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}