namespace Toss_Time_Tracker
{
    partial class frmTimeTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeTracker));
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblDoing = new System.Windows.Forms.Label();
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTest1 = new System.Windows.Forms.Label();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.lblNumTicks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darknessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimer
            // 
            this.txtTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimer.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtTimer.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.Color.Lime;
            this.txtTimer.Location = new System.Drawing.Point(241, 91);
            this.txtTimer.Multiline = true;
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(238, 67);
            this.txtTimer.TabIndex = 1;
            this.txtTimer.Text = "00:00:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimer.UseWaitCursor = true;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.BackColor = System.Drawing.Color.Red;
            this.btnPause.Font = new System.Drawing.Font("Digital-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(285, 819);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(154, 51);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click_1);
            // 
            // lblDoing
            // 
            this.lblDoing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDoing.AutoSize = true;
            this.lblDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoing.ForeColor = System.Drawing.Color.White;
            this.lblDoing.Location = new System.Drawing.Point(214, 161);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(306, 25);
            this.lblDoing.TabIndex = 6;
            this.lblDoing.Text = "What are you currently doing? ";
            // 
            // cmbTask
            // 
            this.cmbTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTask.BackColor = System.Drawing.Color.Black;
            this.cmbTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTask.ForeColor = System.Drawing.Color.White;
            this.cmbTask.FormattingEnabled = true;
            this.cmbTask.Items.AddRange(new object[] {
            "Client Work",
            "Ticket Management",
            "Project",
            "Lunch",
            "Break",
            "Meeting"});
            this.cmbTask.Location = new System.Drawing.Point(202, 201);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Size = new System.Drawing.Size(318, 32);
            this.cmbTask.TabIndex = 7;
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDetails.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDetails.Location = new System.Drawing.Point(12, 257);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(709, 544);
            this.txtDetails.TabIndex = 8;
            this.txtDetails.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Digital-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 819);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(158, 51);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // lblTest1
            // 
            this.lblTest1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTest1.AutoSize = true;
            this.lblTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest1.ForeColor = System.Drawing.Color.White;
            this.lblTest1.Location = new System.Drawing.Point(25, 201);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(53, 20);
            this.lblTest1.TabIndex = 10;
            this.lblTest1.Text = "XXXX";
            this.lblTest1.Visible = false;
            // 
            // lblTest2
            // 
            this.lblTest2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTest2.AutoSize = true;
            this.lblTest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest2.ForeColor = System.Drawing.Color.White;
            this.lblTest2.Location = new System.Drawing.Point(640, 201);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(83, 20);
            this.lblTest2.TabIndex = 11;
            this.lblTest2.Text = "XX:XX:XX";
            this.lblTest2.Visible = false;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSendMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSendMail.Font = new System.Drawing.Font("Digital-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.Location = new System.Drawing.Point(567, 819);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(154, 51);
            this.btnSendMail.TabIndex = 12;
            this.btnSendMail.Text = "Send Log";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendLog_Click);
            // 
            // lblNumTicks
            // 
            this.lblNumTicks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumTicks.AutoSize = true;
            this.lblNumTicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTicks.ForeColor = System.Drawing.Color.White;
            this.lblNumTicks.Location = new System.Drawing.Point(8, 171);
            this.lblNumTicks.Name = "lblNumTicks";
            this.lblNumTicks.Size = new System.Drawing.Size(104, 20);
            this.lblNumTicks.TabIndex = 13;
            this.lblNumTicks.Text = "Num of Ticks:";
            this.lblNumTicks.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(536, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Time Elapsed:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(396, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "RZELLER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 81);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(92, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.logPathToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.settingsToolStripMenuItem.Text = "Settings ";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darknessToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darknessToolStripMenuItem
            // 
            this.darknessToolStripMenuItem.Name = "darknessToolStripMenuItem";
            this.darknessToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.darknessToolStripMenuItem.Text = "Darkness";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // logPathToolStripMenuItem
            // 
            this.logPathToolStripMenuItem.Name = "logPathToolStripMenuItem";
            this.logPathToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.logPathToolStripMenuItem.Text = "Log Path";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.aboutMeToolStripMenuItem.Text = "About Me ";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.howToUseToolStripMenuItem.Text = "How to use ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmTimeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(745, 946);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumTicks);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.lblTest1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.cmbTask);
            this.Controls.Add(this.lblDoing);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTimeTracker";
            this.Text = "Toss Time Tracker ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Label lblNumTicks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darknessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

