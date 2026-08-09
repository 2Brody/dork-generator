namespace DorkMaster
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
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDorkList = new System.Windows.Forms.TextBox();
            this.lblDorkMaster = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFunction = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnFormats = new System.Windows.Forms.Button();
            this.btnImportKey = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPatterns = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtSites = new System.Windows.Forms.TextBox();
            this.btnSite = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnResetPatterns = new System.Windows.Forms.Button();
            this.lblTelegramLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblGithubLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeyword.ForeColor = System.Drawing.SystemColors.Control;
            this.txtKeyword.Location = new System.Drawing.Point(0, 24);
            this.txtKeyword.Multiline = true;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyword.Size = new System.Drawing.Size(220, 332);
            this.txtKeyword.TabIndex = 1;
            // 
            // txtFormat
            // 
            this.txtFormat.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFormat.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFormat.Location = new System.Drawing.Point(1, 20);
            this.txtFormat.Multiline = true;
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFormat.Size = new System.Drawing.Size(150, 90);
            this.txtFormat.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtType.ForeColor = System.Drawing.SystemColors.Control;
            this.txtType.Location = new System.Drawing.Point(1, 20);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtType.Size = new System.Drawing.Size(150, 90);
            this.txtType.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(637, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDorkList
            // 
            this.txtDorkList.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtDorkList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDorkList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDorkList.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDorkList.Location = new System.Drawing.Point(0, 20);
            this.txtDorkList.Multiline = true;
            this.txtDorkList.Name = "txtDorkList";
            this.txtDorkList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDorkList.Size = new System.Drawing.Size(274, 503);
            this.txtDorkList.TabIndex = 21;
            this.txtDorkList.TabStop = false;
            // 
            // lblDorkMaster
            // 
            this.lblDorkMaster.AutoSize = true;
            this.lblDorkMaster.BackColor = System.Drawing.Color.Transparent;
            this.lblDorkMaster.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDorkMaster.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDorkMaster.Location = new System.Drawing.Point(261, 22);
            this.lblDorkMaster.Name = "lblDorkMaster";
            this.lblDorkMaster.Size = new System.Drawing.Size(180, 47);
            this.lblDorkMaster.TabIndex = 25;
            this.lblDorkMaster.Text = "DorkMaster";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(248, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keywords";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFormat);
            this.groupBox2.ForeColor = System.Drawing.Color.Orange;
            this.groupBox2.Location = new System.Drawing.Point(481, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Page Format";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtType);
            this.groupBox3.ForeColor = System.Drawing.Color.Orange;
            this.groupBox3.Location = new System.Drawing.Point(482, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 110);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Page Type";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFunction);
            this.groupBox4.ForeColor = System.Drawing.Color.Orange;
            this.groupBox4.Location = new System.Drawing.Point(480, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 110);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Function";
            // 
            // txtFunction
            // 
            this.txtFunction.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFunction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFunction.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFunction.Location = new System.Drawing.Point(1, 20);
            this.txtFunction.Multiline = true;
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFunction.Size = new System.Drawing.Size(150, 90);
            this.txtFunction.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDorkList);
            this.groupBox5.ForeColor = System.Drawing.Color.Orange;
            this.groupBox5.Location = new System.Drawing.Point(636, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 525);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dork List";
            // 
            // btnFunction
            // 
            this.btnFunction.BackColor = System.Drawing.Color.Orange;
            this.btnFunction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFunction.Location = new System.Drawing.Point(480, 548);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(150, 21);
            this.btnFunction.TabIndex = 39;
            this.btnFunction.TabStop = false;
            this.btnFunction.Text = "IMPORT Function from File";
            this.btnFunction.UseVisualStyleBackColor = false;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.Orange;
            this.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnType.Location = new System.Drawing.Point(480, 411);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(151, 20);
            this.btnType.TabIndex = 40;
            this.btnType.TabStop = false;
            this.btnType.Text = "IMPORT Type from File";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnFormats
            // 
            this.btnFormats.BackColor = System.Drawing.Color.Orange;
            this.btnFormats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFormats.Location = new System.Drawing.Point(481, 270);
            this.btnFormats.Name = "btnFormats";
            this.btnFormats.Size = new System.Drawing.Size(150, 20);
            this.btnFormats.TabIndex = 41;
            this.btnFormats.TabStop = false;
            this.btnFormats.Text = "IMPORT Format from File";
            this.btnFormats.UseVisualStyleBackColor = false;
            this.btnFormats.Click += new System.EventHandler(this.btnFormats_Click);
            // 
            // btnImportKey
            // 
            this.btnImportKey.BackColor = System.Drawing.Color.Orange;
            this.btnImportKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportKey.Location = new System.Drawing.Point(248, 376);
            this.btnImportKey.Name = "btnImportKey";
            this.btnImportKey.Size = new System.Drawing.Size(220, 20);
            this.btnImportKey.TabIndex = 42;
            this.btnImportKey.TabStop = false;
            this.btnImportKey.Text = "IMPORT Keywords from File";
            this.btnImportKey.UseVisualStyleBackColor = false;
            this.btnImportKey.Click += new System.EventHandler(this.btnImportKey_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.btnGuide);
            this.groupBox8.Controls.Add(this.btnFolder);
            this.groupBox8.Controls.Add(this.numericUpDown1);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.lblDorkMaster);
            this.groupBox8.ForeColor = System.Drawing.Color.Orange;
            this.groupBox8.Location = new System.Drawing.Point(12, 400);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(456, 173);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Settings";
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.Orange;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuide.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnGuide.Location = new System.Drawing.Point(20, 123);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(110, 25);
            this.btnGuide.TabIndex = 49;
            this.btnGuide.TabStop = false;
            this.btnGuide.Text = "Guide and Info";
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.BackColor = System.Drawing.Color.Orange;
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFolder.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnFolder.Location = new System.Drawing.Point(20, 92);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(110, 25);
            this.btnFolder.TabIndex = 48;
            this.btnFolder.TabStop = false;
            this.btnFolder.Text = "DorkMaster Folder";
            this.btnFolder.UseVisualStyleBackColor = false;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.ForeColor = System.Drawing.Color.YellowGreen;
            this.numericUpDown1.Location = new System.Drawing.Point(99, 40);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(142, 21);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dork Amount :";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Orange;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Location = new System.Drawing.Point(782, 543);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(130, 30);
            this.btnGenerate.TabIndex = 44;
            this.btnGenerate.TabStop = false;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPatterns);
            this.groupBox6.ForeColor = System.Drawing.Color.Orange;
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(230, 358);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DORK TYPE";
            // 
            // txtPatterns
            // 
            this.txtPatterns.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtPatterns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatterns.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatterns.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPatterns.Location = new System.Drawing.Point(0, 20);
            this.txtPatterns.Multiline = true;
            this.txtPatterns.Name = "txtPatterns";
            this.txtPatterns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPatterns.Size = new System.Drawing.Size(230, 336);
            this.txtPatterns.TabIndex = 6;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtSites);
            this.groupBox9.ForeColor = System.Drawing.Color.Orange;
            this.groupBox9.Location = new System.Drawing.Point(480, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(150, 110);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Site";
            // 
            // txtSites
            // 
            this.txtSites.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtSites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSites.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSites.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSites.Location = new System.Drawing.Point(1, 20);
            this.txtSites.Multiline = true;
            this.txtSites.Name = "txtSites";
            this.txtSites.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSites.Size = new System.Drawing.Size(150, 90);
            this.txtSites.TabIndex = 2;
            // 
            // btnSite
            // 
            this.btnSite.BackColor = System.Drawing.Color.Orange;
            this.btnSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSite.Location = new System.Drawing.Point(481, 128);
            this.btnSite.Name = "btnSite";
            this.btnSite.Size = new System.Drawing.Size(150, 20);
            this.btnSite.TabIndex = 45;
            this.btnSite.TabStop = false;
            this.btnSite.Text = "IMPORT Site List from File";
            this.btnSite.UseVisualStyleBackColor = false;
            this.btnSite.Click += new System.EventHandler(this.btnSite_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMessage.ForeColor = System.Drawing.Color.Gold;
            this.txtMessage.Location = new System.Drawing.Point(12, 581);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(898, 25);
            this.txtMessage.TabIndex = 37;
            this.txtMessage.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(137, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 20);
            this.button1.TabIndex = 46;
            this.button1.TabStop = false;
            this.button1.Text = "IMPORT Patterns";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResetPatterns
            // 
            this.btnResetPatterns.BackColor = System.Drawing.Color.Orange;
            this.btnResetPatterns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetPatterns.Location = new System.Drawing.Point(12, 374);
            this.btnResetPatterns.Name = "btnResetPatterns";
            this.btnResetPatterns.Size = new System.Drawing.Size(105, 20);
            this.btnResetPatterns.TabIndex = 47;
            this.btnResetPatterns.TabStop = false;
            this.btnResetPatterns.Text = "Reset Patterns";
            this.btnResetPatterns.UseVisualStyleBackColor = false;
            this.btnResetPatterns.Click += new System.EventHandler(this.btnResetPatterns_Click);
            // 
            // lblTelegramLink
            // 
            this.lblTelegramLink.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblTelegramLink.Image = global::DorkMaster.Properties.Resources._3488463;
            this.lblTelegramLink.Name = "lblTelegramLink";
            this.lblTelegramLink.Size = new System.Drawing.Size(71, 17);
            this.lblTelegramLink.Text = "Telegram";
            this.lblTelegramLink.Click += new System.EventHandler(this.lblTelegramLink_Click);
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel9.Text = "|";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DimGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel9,
            this.lblTelegramLink,
            this.toolStripStatusLabel1,
            this.lblGithubLink});
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblGithubLink
            // 
            this.lblGithubLink.ForeColor = System.Drawing.Color.MintCream;
            this.lblGithubLink.Image = global::DorkMaster.Properties.Resources.Github;
            this.lblGithubLink.Name = "lblGithubLink";
            this.lblGithubLink.Size = new System.Drawing.Size(135, 17);
            this.lblGithubLink.Text = "Github [open source]";
            this.lblGithubLink.Click += new System.EventHandler(this.lblGithubLink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::DorkMaster.Properties.Resources._20564106;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 634);
            this.Controls.Add(this.btnResetPatterns);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSite);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnFormats);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnImportKey);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(940, 700);
            this.Name = "Form1";
            this.Text = "DorkMaster | V 1.4 [open source]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDorkList;
        private System.Windows.Forms.Label lblDorkMaster;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnFormats;
        private System.Windows.Forms.Button btnImportKey;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPatterns;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtSites;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Button btnSite;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnResetPatterns;
        private System.Windows.Forms.ToolStripStatusLabel lblTelegramLink;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.ToolStripStatusLabel lblGithubLink;
    }
}

