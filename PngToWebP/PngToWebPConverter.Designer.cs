namespace PngToWebP
{
    partial class PngToWebPConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PngToWebPConverter));
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFolder = new System.Windows.Forms.RadioButton();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.txtConvert = new System.Windows.Forms.Button();
            this.cbBackup = new System.Windows.Forms.CheckBox();
            this.tbQuality = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.qualityToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.ttBackup = new System.Windows.Forms.ToolTip(this.components);
            this.ttDelete = new System.Windows.Forms.ToolTip(this.components);
            this.llOpenOutput = new System.Windows.Forms.LinkLabel();
            this.llFilter = new System.Windows.Forms.Label();
            this.ttFilter = new System.Windows.Forms.ToolTip(this.components);
            this.cbPNG = new System.Windows.Forms.CheckBox();
            this.cbJPG = new System.Windows.Forms.CheckBox();
            this.cbTiff = new System.Windows.Forms.CheckBox();
            this.cbJPEG = new System.Windows.Forms.CheckBox();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(70, 50);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(46, 17);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path*:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(118, 44);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(428, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(553, 44);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFolder);
            this.groupBox1.Controls.Add(this.rbFile);
            this.groupBox1.Location = new System.Drawing.Point(118, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 35);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rbFolder
            // 
            this.rbFolder.AutoSize = true;
            this.rbFolder.Location = new System.Drawing.Point(136, 10);
            this.rbFolder.Name = "rbFolder";
            this.rbFolder.Size = new System.Drawing.Size(69, 21);
            this.rbFolder.TabIndex = 1;
            this.rbFolder.Text = "Folder";
            this.rbFolder.UseVisualStyleBackColor = true;
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Checked = true;
            this.rbFile.Location = new System.Drawing.Point(57, 10);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(51, 21);
            this.rbFile.TabIndex = 0;
            this.rbFile.TabStop = true;
            this.rbFile.Text = "File";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // txtConvert
            // 
            this.txtConvert.Location = new System.Drawing.Point(271, 262);
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(147, 51);
            this.txtConvert.TabIndex = 18;
            this.txtConvert.Text = "Convert";
            this.txtConvert.UseVisualStyleBackColor = true;
            this.txtConvert.Click += new System.EventHandler(this.txtConvert_Click);
            // 
            // cbBackup
            // 
            this.cbBackup.AutoSize = true;
            this.cbBackup.Checked = true;
            this.cbBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBackup.Location = new System.Drawing.Point(118, 128);
            this.cbBackup.Name = "cbBackup";
            this.cbBackup.Size = new System.Drawing.Size(77, 21);
            this.cbBackup.TabIndex = 20;
            this.cbBackup.Text = "Backup";
            this.cbBackup.UseVisualStyleBackColor = true;
            // 
            // tbQuality
            // 
            this.tbQuality.Location = new System.Drawing.Point(118, 199);
            this.tbQuality.Maximum = 100;
            this.tbQuality.Minimum = 10;
            this.tbQuality.Name = "tbQuality";
            this.tbQuality.Size = new System.Drawing.Size(428, 56);
            this.tbQuality.TabIndex = 22;
            this.tbQuality.Value = 80;
            this.tbQuality.Scroll += new System.EventHandler(this.tbQuality_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quality:";
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(215, 128);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(124, 21);
            this.cbDelete.TabIndex = 24;
            this.cbDelete.Text = "Delete Original";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // llOpenOutput
            // 
            this.llOpenOutput.AutoSize = true;
            this.llOpenOutput.Location = new System.Drawing.Point(424, 294);
            this.llOpenOutput.Name = "llOpenOutput";
            this.llOpenOutput.Size = new System.Drawing.Size(130, 17);
            this.llOpenOutput.TabIndex = 26;
            this.llOpenOutput.TabStop = true;
            this.llOpenOutput.Text = "Open Output folder";
            this.llOpenOutput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOpenOutput_LinkClicked);
            // 
            // llFilter
            // 
            this.llFilter.AutoSize = true;
            this.llFilter.Location = new System.Drawing.Point(65, 166);
            this.llFilter.Name = "llFilter";
            this.llFilter.Size = new System.Drawing.Size(48, 17);
            this.llFilter.TabIndex = 27;
            this.llFilter.Text = "Filter*:";
            // 
            // cbPNG
            // 
            this.cbPNG.AutoSize = true;
            this.cbPNG.Location = new System.Drawing.Point(119, 165);
            this.cbPNG.Name = "cbPNG";
            this.cbPNG.Size = new System.Drawing.Size(60, 21);
            this.cbPNG.TabIndex = 28;
            this.cbPNG.Text = "PNG";
            this.cbPNG.UseVisualStyleBackColor = true;
            // 
            // cbJPG
            // 
            this.cbJPG.AutoSize = true;
            this.cbJPG.Location = new System.Drawing.Point(185, 165);
            this.cbJPG.Name = "cbJPG";
            this.cbJPG.Size = new System.Drawing.Size(57, 21);
            this.cbJPG.TabIndex = 29;
            this.cbJPG.Text = "JPG";
            this.cbJPG.UseVisualStyleBackColor = true;
            // 
            // cbTiff
            // 
            this.cbTiff.AutoSize = true;
            this.cbTiff.Location = new System.Drawing.Point(320, 164);
            this.cbTiff.Name = "cbTiff";
            this.cbTiff.Size = new System.Drawing.Size(58, 21);
            this.cbTiff.TabIndex = 30;
            this.cbTiff.Text = "TIFF";
            this.cbTiff.UseVisualStyleBackColor = true;
            // 
            // cbJPEG
            // 
            this.cbJPEG.AutoSize = true;
            this.cbJPEG.Location = new System.Drawing.Point(248, 165);
            this.cbJPEG.Name = "cbJPEG";
            this.cbJPEG.Size = new System.Drawing.Size(66, 21);
            this.cbJPEG.TabIndex = 31;
            this.cbJPEG.Text = "JPEG";
            this.cbJPEG.UseVisualStyleBackColor = true;
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msMain.Size = new System.Drawing.Size(704, 28);
            this.msMain.TabIndex = 32;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PngToWebPConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 320);
            this.Controls.Add(this.cbJPEG);
            this.Controls.Add(this.cbTiff);
            this.Controls.Add(this.cbJPG);
            this.Controls.Add(this.cbPNG);
            this.Controls.Add(this.llFilter);
            this.Controls.Add(this.llOpenOutput);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQuality);
            this.Controls.Add(this.cbBackup);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(722, 365);
            this.MinimumSize = new System.Drawing.Size(722, 365);
            this.Name = "PngToWebPConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PNG to WebP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFolder;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.Button txtConvert;
        private System.Windows.Forms.CheckBox cbBackup;
        private System.Windows.Forms.TrackBar tbQuality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip qualityToolTip;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.ToolTip ttBackup;
        private System.Windows.Forms.ToolTip ttDelete;
        private System.Windows.Forms.LinkLabel llOpenOutput;
        private System.Windows.Forms.Label llFilter;
        private System.Windows.Forms.ToolTip ttFilter;
        private System.Windows.Forms.CheckBox cbPNG;
        private System.Windows.Forms.CheckBox cbJPG;
        private System.Windows.Forms.CheckBox cbTiff;
        private System.Windows.Forms.CheckBox cbJPEG;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

