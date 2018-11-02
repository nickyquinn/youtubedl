namespace YoutubeDl
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtVideoUrl = new System.Windows.Forms.TextBox();
            this.chkAudioOnly = new System.Windows.Forms.CheckBox();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doofersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitYourJibberJabberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSaveFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(908, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVideoUrl
            // 
            this.txtVideoUrl.Location = new System.Drawing.Point(187, 127);
            this.txtVideoUrl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtVideoUrl.Name = "txtVideoUrl";
            this.txtVideoUrl.Size = new System.Drawing.Size(556, 29);
            this.txtVideoUrl.TabIndex = 1;
            // 
            // chkAudioOnly
            // 
            this.chkAudioOnly.AutoSize = true;
            this.chkAudioOnly.Location = new System.Drawing.Point(757, 133);
            this.chkAudioOnly.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkAudioOnly.Name = "chkAudioOnly";
            this.chkAudioOnly.Size = new System.Drawing.Size(143, 29);
            this.chkAudioOnly.TabIndex = 2;
            this.chkAudioOnly.Text = "Create MP3";
            this.chkAudioOnly.UseVisualStyleBackColor = true;
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Location = new System.Drawing.Point(22, 292);
            this.mainProgressBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(908, 41);
            this.mainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.mainProgressBar.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doofersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(952, 42);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doofersToolStripMenuItem
            // 
            this.doofersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.quitYourJibberJabberToolStripMenuItem});
            this.doofersToolStripMenuItem.Name = "doofersToolStripMenuItem";
            this.doofersToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.doofersToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // quitYourJibberJabberToolStripMenuItem
            // 
            this.quitYourJibberJabberToolStripMenuItem.Name = "quitYourJibberJabberToolStripMenuItem";
            this.quitYourJibberJabberToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.quitYourJibberJabberToolStripMenuItem.Text = "&Quit";
            this.quitYourJibberJabberToolStripMenuItem.Click += new System.EventHandler(this.quitYourJibberJabberToolStripMenuItem_Click);
            // 
            // txtSaveFolder
            // 
            this.txtSaveFolder.Location = new System.Drawing.Point(187, 50);
            this.txtSaveFolder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSaveFolder.Name = "txtSaveFolder";
            this.txtSaveFolder.ReadOnly = true;
            this.txtSaveFolder.Size = new System.Drawing.Size(556, 29);
            this.txtSaveFolder.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Save folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "YouTube URL:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(759, 50);
            this.btnChange.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(138, 42);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtTerminal
            // 
            this.txtTerminal.Location = new System.Drawing.Point(22, 343);
            this.txtTerminal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTerminal.Multiline = true;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.ReadOnly = true;
            this.txtTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTerminal.Size = new System.Drawing.Size(904, 294);
            this.txtTerminal.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 663);
            this.Controls.Add(this.txtTerminal);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaveFolder);
            this.Controls.Add(this.mainProgressBar);
            this.Controls.Add(this.chkAudioOnly);
            this.Controls.Add(this.txtVideoUrl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Web video downloader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVideoUrl;
        private System.Windows.Forms.CheckBox chkAudioOnly;
        private System.Windows.Forms.ProgressBar mainProgressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doofersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitYourJibberJabberToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSaveFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

