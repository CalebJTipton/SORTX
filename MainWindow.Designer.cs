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
            this.browseDirectory_btn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.directoryPath_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // browseDirectory_btn
            // 
            this.browseDirectory_btn.Location = new System.Drawing.Point(420, 64);
            this.browseDirectory_btn.Name = "browseDirectory_btn";
            this.browseDirectory_btn.Size = new System.Drawing.Size(75, 23);
            this.browseDirectory_btn.TabIndex = 0;
            this.browseDirectory_btn.Text = "Browse";
            this.browseDirectory_btn.UseVisualStyleBackColor = true;
            this.browseDirectory_btn.Click += new System.EventHandler(this.browseDirectory_btn_Click);
            // 
            // directoryPath_txt
            // 
            this.directoryPath_txt.Location = new System.Drawing.Point(207, 65);
            this.directoryPath_txt.Name = "directoryPath_txt";
            this.directoryPath_txt.Size = new System.Drawing.Size(190, 23);
            this.directoryPath_txt.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 571);
            this.Controls.Add(this.directoryPath_txt);
            this.Controls.Add(this.browseDirectory_btn);
            this.Name = "MainWindow";
            this.Text = "SORTX V0.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button browseDirectory_btn;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox directoryPath_txt;
    }
}