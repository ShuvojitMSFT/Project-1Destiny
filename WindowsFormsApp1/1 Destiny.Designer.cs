using System.Windows.Forms;

namespace Project_1Destiny

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
            this.Reset = new System.Windows.Forms.Button();
            this.SOAPNotes = new System.Windows.Forms.RichTextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.SendToEscalation = new System.Windows.Forms.Button();
            this.CaseNumber = new System.Windows.Forms.TextBox();
            this.CaseNumberLabel = new System.Windows.Forms.Label();
            this.SendToOneNote = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Soap_template = new System.Windows.Forms.RichTextBox();
            this.QuickAssist = new System.Windows.Forms.Button();
            this.scrappad = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.EST = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MST = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CST = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.PST = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.CET = new System.Windows.Forms.Label();
            this.GMT = new System.Windows.Forms.Label();
            this.ARAB = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.wrdbtn = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbrFont = new System.Windows.Forms.ToolStripButton();
            this.tspColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbrBold = new System.Windows.Forms.ToolStripButton();
            this.tbrItalic = new System.Windows.Forms.ToolStripButton();
            this.tbrUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbrLeft = new System.Windows.Forms.ToolStripButton();
            this.tbrCenter = new System.Windows.Forms.ToolStripButton();
            this.tbrRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.insrtImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.screencapturebtn = new System.Windows.Forms.Button();
            this.lblarea = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbtimezone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.lbstopwatch = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.commitbtn = new System.Windows.Forms.Button();
            this.CaseListBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.whatisnt = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.whereis = new System.Windows.Forms.RichTextBox();
            this.whatis = new System.Windows.Forms.RichTextBox();
            this.whereisnt = new System.Windows.Forms.RichTextBox();
            this.whenis = new System.Windows.Forms.RichTextBox();
            this.whenisnt = new System.Windows.Forms.RichTextBox();
            this.extentis = new System.Windows.Forms.RichTextBox();
            this.extentisnt = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.meetingbtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(36, 46);
            this.Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(121, 29);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Home";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SOAPNotes
            // 
            this.SOAPNotes.AcceptsTab = true;
            this.SOAPNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SOAPNotes.BulletIndent = 2;
            this.SOAPNotes.EnableAutoDragDrop = true;
            this.SOAPNotes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOAPNotes.Location = new System.Drawing.Point(178, 104);
            this.SOAPNotes.Margin = new System.Windows.Forms.Padding(2);
            this.SOAPNotes.Name = "SOAPNotes";
            this.SOAPNotes.Size = new System.Drawing.Size(565, 634);
            this.SOAPNotes.TabIndex = 1;
            this.SOAPNotes.Text = "";
            this.SOAPNotes.TextChanged += new System.EventHandler(this.SOAPNotes_TextChanged);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(36, 114);
            this.Copy.Margin = new System.Windows.Forms.Padding(2);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(121, 29);
            this.Copy.TabIndex = 2;
            this.Copy.Text = "Copy Content";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // SendToEscalation
            // 
            this.SendToEscalation.Location = new System.Drawing.Point(36, 182);
            this.SendToEscalation.Margin = new System.Windows.Forms.Padding(2);
            this.SendToEscalation.Name = "SendToEscalation";
            this.SendToEscalation.Size = new System.Drawing.Size(121, 29);
            this.SendToEscalation.TabIndex = 3;
            this.SendToEscalation.Text = "Send to Escalation";
            this.SendToEscalation.UseVisualStyleBackColor = true;
            this.SendToEscalation.Click += new System.EventHandler(this.SendToEscalation_Click);
            // 
            // CaseNumber
            // 
            this.CaseNumber.Location = new System.Drawing.Point(279, 29);
            this.CaseNumber.Margin = new System.Windows.Forms.Padding(2);
            this.CaseNumber.Name = "CaseNumber";
            this.CaseNumber.Size = new System.Drawing.Size(93, 22);
            this.CaseNumber.TabIndex = 6;
            this.CaseNumber.TextChanged += new System.EventHandler(this.CaseNumber_TextChanged);
            // 
            // CaseNumberLabel
            // 
            this.CaseNumberLabel.AutoSize = true;
            this.CaseNumberLabel.Location = new System.Drawing.Point(175, 32);
            this.CaseNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CaseNumberLabel.Name = "CaseNumberLabel";
            this.CaseNumberLabel.Size = new System.Drawing.Size(100, 17);
            this.CaseNumberLabel.TabIndex = 7;
            this.CaseNumberLabel.Text = "Case number :";
            this.CaseNumberLabel.Click += new System.EventHandler(this.CaseNumberLabel_Click);
            // 
            // SendToOneNote
            // 
            this.SendToOneNote.Location = new System.Drawing.Point(36, 148);
            this.SendToOneNote.Name = "SendToOneNote";
            this.SendToOneNote.Size = new System.Drawing.Size(121, 29);
            this.SendToOneNote.TabIndex = 8;
            this.SendToOneNote.Text = "Send to OneNote";
            this.SendToOneNote.UseVisualStyleBackColor = true;
            this.SendToOneNote.Click += new System.EventHandler(this.SendToOneNote_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.Location = new System.Drawing.Point(1232, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Suggestion/Feedback?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FeedbackLink_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 755);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1374, 25);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Soap_template
            // 
            this.Soap_template.Location = new System.Drawing.Point(785, 743);
            this.Soap_template.Name = "Soap_template";
            this.Soap_template.Size = new System.Drawing.Size(58, 25);
            this.Soap_template.TabIndex = 19;
            this.Soap_template.Text = resources.GetString("Soap_template.Text");
            this.Soap_template.Visible = false;
            this.Soap_template.TextChanged += new System.EventHandler(this.OffGen_Soap_TextChanged);
            // 
            // QuickAssist
            // 
            this.QuickAssist.Location = new System.Drawing.Point(36, 248);
            this.QuickAssist.Name = "QuickAssist";
            this.QuickAssist.Size = new System.Drawing.Size(121, 29);
            this.QuickAssist.TabIndex = 23;
            this.QuickAssist.Text = "Launch Quick Assist";
            this.QuickAssist.UseVisualStyleBackColor = true;
            this.QuickAssist.Click += new System.EventHandler(this.button1_Click);
            // 
            // scrappad
            // 
            this.scrappad.AcceptsTab = true;
            this.scrappad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrappad.AutoWordSelection = true;
            this.scrappad.EnableAutoDragDrop = true;
            this.scrappad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrappad.Location = new System.Drawing.Point(762, 484);
            this.scrappad.Margin = new System.Windows.Forms.Padding(2);
            this.scrappad.Name = "scrappad";
            this.scrappad.Size = new System.Drawing.Size(601, 253);
            this.scrappad.TabIndex = 24;
            this.scrappad.Text = "";
            this.scrappad.TextChanged += new System.EventHandler(this.scrappad_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Reset Template";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EST
            // 
            this.EST.AutoSize = true;
            this.EST.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EST.ForeColor = System.Drawing.Color.Black;
            this.EST.Location = new System.Drawing.Point(3, 0);
            this.EST.Name = "EST";
            this.EST.Size = new System.Drawing.Size(46, 22);
            this.EST.TabIndex = 27;
            this.EST.Text = "EST";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MST
            // 
            this.MST.AutoSize = true;
            this.MST.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MST.ForeColor = System.Drawing.Color.Black;
            this.MST.Location = new System.Drawing.Point(3, 44);
            this.MST.Name = "MST";
            this.MST.Size = new System.Drawing.Size(46, 22);
            this.MST.TabIndex = 28;
            this.MST.Text = "MST";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CST
            // 
            this.CST.AutoSize = true;
            this.CST.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CST.ForeColor = System.Drawing.Color.Black;
            this.CST.Location = new System.Drawing.Point(3, 22);
            this.CST.Name = "CST";
            this.CST.Size = new System.Drawing.Size(46, 22);
            this.CST.TabIndex = 29;
            this.CST.Text = "CST";
            this.CST.Click += new System.EventHandler(this.CST_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // PST
            // 
            this.PST.AutoSize = true;
            this.PST.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PST.ForeColor = System.Drawing.Color.Black;
            this.PST.Location = new System.Drawing.Point(3, 66);
            this.PST.Name = "PST";
            this.PST.Size = new System.Drawing.Size(46, 22);
            this.PST.TabIndex = 30;
            this.PST.Text = "PST";
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // CET
            // 
            this.CET.AutoSize = true;
            this.CET.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CET.ForeColor = System.Drawing.Color.Black;
            this.CET.Location = new System.Drawing.Point(3, 88);
            this.CET.Name = "CET";
            this.CET.Size = new System.Drawing.Size(58, 22);
            this.CET.TabIndex = 31;
            this.CET.Text = "CEST";
            this.CET.Click += new System.EventHandler(this.CET_Click);
            // 
            // GMT
            // 
            this.GMT.AutoSize = true;
            this.GMT.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GMT.ForeColor = System.Drawing.Color.Black;
            this.GMT.Location = new System.Drawing.Point(3, 110);
            this.GMT.Name = "GMT";
            this.GMT.Size = new System.Drawing.Size(46, 22);
            this.GMT.TabIndex = 32;
            this.GMT.Text = "GMT";
            // 
            // ARAB
            // 
            this.ARAB.AutoSize = true;
            this.ARAB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARAB.ForeColor = System.Drawing.Color.Black;
            this.ARAB.Location = new System.Drawing.Point(3, 132);
            this.ARAB.Name = "ARAB";
            this.ARAB.Size = new System.Drawing.Size(82, 22);
            this.ARAB.TabIndex = 33;
            this.ARAB.Text = "M.EAST";
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 20;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Enabled = true;
            this.timer6.Interval = 20;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Enabled = true;
            this.timer7.Interval = 20;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.EST);
            this.flowLayoutPanel1.Controls.Add(this.CST);
            this.flowLayoutPanel1.Controls.Add(this.MST);
            this.flowLayoutPanel1.Controls.Add(this.PST);
            this.flowLayoutPanel1.Controls.Add(this.CET);
            this.flowLayoutPanel1.Controls.Add(this.GMT);
            this.flowLayoutPanel1.Controls.Add(this.ARAB);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 405);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(161, 139);
            this.flowLayoutPanel1.TabIndex = 39;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "World Time";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(1046, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Notes Section";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // wrdbtn
            // 
            this.wrdbtn.Location = new System.Drawing.Point(36, 216);
            this.wrdbtn.Name = "wrdbtn";
            this.wrdbtn.Size = new System.Drawing.Size(121, 29);
            this.wrdbtn.TabIndex = 43;
            this.wrdbtn.Text = "Edit in Word";
            this.wrdbtn.UseVisualStyleBackColor = true;
            this.wrdbtn.Click += new System.EventHandler(this.wrdbtn_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(277, 5);
            this.toolStripContainer1.Location = new System.Drawing.Point(178, 67);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(277, 32);
            this.toolStripContainer1.TabIndex = 44;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbrFont,
            this.tspColor,
            this.toolStripSeparator1,
            this.tbrBold,
            this.tbrItalic,
            this.tbrUnderline,
            this.toolStripSeparator2,
            this.tbrLeft,
            this.tbrCenter,
            this.tbrRight,
            this.toolStripSeparator3,
            this.insrtImage,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(270, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // tbrFont
            // 
            this.tbrFont.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbrFont.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.font;
            this.tbrFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrFont.Image = global::WindowsFormsApp1.Properties.Resources.font;
            this.tbrFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrFont.Name = "tbrFont";
            this.tbrFont.Size = new System.Drawing.Size(24, 24);
            this.tbrFont.Text = "toolStripButton1";
            this.tbrFont.ToolTipText = "Font";
            this.tbrFont.Click += new System.EventHandler(this.tbrFont_Click);
            // 
            // tspColor
            // 
            this.tspColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspColor.Image = ((System.Drawing.Image)(resources.GetObject("tspColor.Image")));
            this.tspColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspColor.Name = "tspColor";
            this.tspColor.Size = new System.Drawing.Size(24, 24);
            this.tspColor.Text = "toolStripButton2";
            this.tspColor.ToolTipText = "FontColor";
            this.tspColor.Click += new System.EventHandler(this.tspColor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tbrBold
            // 
            this.tbrBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrBold.Image = global::WindowsFormsApp1.Properties.Resources.bold;
            this.tbrBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrBold.Name = "tbrBold";
            this.tbrBold.Size = new System.Drawing.Size(24, 24);
            this.tbrBold.Text = "toolStripButton3";
            this.tbrBold.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tbrBold.ToolTipText = "Bold";
            this.tbrBold.Click += new System.EventHandler(this.tbrBold_Click);
            // 
            // tbrItalic
            // 
            this.tbrItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrItalic.Image = global::WindowsFormsApp1.Properties.Resources.italic;
            this.tbrItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrItalic.Name = "tbrItalic";
            this.tbrItalic.Size = new System.Drawing.Size(24, 24);
            this.tbrItalic.Text = "toolStripButton4";
            this.tbrItalic.ToolTipText = "Italics";
            this.tbrItalic.Click += new System.EventHandler(this.tbrItalic_Click);
            // 
            // tbrUnderline
            // 
            this.tbrUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrUnderline.Image = global::WindowsFormsApp1.Properties.Resources.underlne;
            this.tbrUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrUnderline.Name = "tbrUnderline";
            this.tbrUnderline.Size = new System.Drawing.Size(24, 24);
            this.tbrUnderline.Text = "toolStripButton5";
            this.tbrUnderline.ToolTipText = "Underline";
            this.tbrUnderline.Click += new System.EventHandler(this.tbrUnderline_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbrLeft
            // 
            this.tbrLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrLeft.Image = global::WindowsFormsApp1.Properties.Resources.left;
            this.tbrLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrLeft.Name = "tbrLeft";
            this.tbrLeft.Size = new System.Drawing.Size(24, 24);
            this.tbrLeft.Text = "toolStripButton6";
            this.tbrLeft.ToolTipText = "Left";
            this.tbrLeft.Click += new System.EventHandler(this.tbrLeft_Click);
            // 
            // tbrCenter
            // 
            this.tbrCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrCenter.Image = global::WindowsFormsApp1.Properties.Resources.centre;
            this.tbrCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrCenter.Name = "tbrCenter";
            this.tbrCenter.Size = new System.Drawing.Size(24, 24);
            this.tbrCenter.Text = "toolStripButton7";
            this.tbrCenter.ToolTipText = "Centre";
            this.tbrCenter.Click += new System.EventHandler(this.tbrCenter_Click);
            // 
            // tbrRight
            // 
            this.tbrRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrRight.Image = global::WindowsFormsApp1.Properties.Resources.right;
            this.tbrRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrRight.Name = "tbrRight";
            this.tbrRight.Size = new System.Drawing.Size(24, 24);
            this.tbrRight.Text = "toolStripButton8";
            this.tbrRight.ToolTipText = "Right";
            this.tbrRight.Click += new System.EventHandler(this.tbrRight_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // insrtImage
            // 
            this.insrtImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insrtImage.Image = ((System.Drawing.Image)(resources.GetObject("insrtImage.Image")));
            this.insrtImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insrtImage.Name = "insrtImage";
            this.insrtImage.Size = new System.Drawing.Size(24, 24);
            this.insrtImage.Text = "toolStripButton1";
            this.insrtImage.ToolTipText = "Insert Image";
            this.insrtImage.Click += new System.EventHandler(this.insrtImage_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Bullets";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog1";
            // 
            // screencapturebtn
            // 
            this.screencapturebtn.Location = new System.Drawing.Point(36, 315);
            this.screencapturebtn.Name = "screencapturebtn";
            this.screencapturebtn.Size = new System.Drawing.Size(121, 29);
            this.screencapturebtn.TabIndex = 45;
            this.screencapturebtn.Text = "Record Screen";
            this.screencapturebtn.UseVisualStyleBackColor = true;
            this.screencapturebtn.Click += new System.EventHandler(this.screencapturebtn_Click);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(12, 571);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(75, 17);
            this.lblarea.TabIndex = 46;
            this.lblarea.Text = "AreaCode:";
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(86, 571);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(54, 22);
            this.tbArea.TabIndex = 47;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 606);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 48;
            this.button3.Text = "GetTimezone";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 49;
            // 
            // lbtimezone
            // 
            this.lbtimezone.AutoSize = true;
            this.lbtimezone.Location = new System.Drawing.Point(130, 609);
            this.lbtimezone.Name = "lbtimezone";
            this.lbtimezone.Size = new System.Drawing.Size(13, 17);
            this.lbtimezone.TabIndex = 50;
            this.lbtimezone.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "StopWatch:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(567, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 23);
            this.button5.TabIndex = 53;
            this.button5.Text = "Start";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(631, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 23);
            this.button6.TabIndex = 54;
            this.button6.TabStop = false;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer8
            // 
            this.timer8.Enabled = true;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // lbstopwatch
            // 
            this.lbstopwatch.AutoSize = true;
            this.lbstopwatch.Location = new System.Drawing.Point(470, 82);
            this.lbstopwatch.Name = "lbstopwatch";
            this.lbstopwatch.Size = new System.Drawing.Size(84, 17);
            this.lbstopwatch.TabIndex = 55;
            this.lbstopwatch.Text = "00:00:00:00";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(399, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 23);
            this.button7.TabIndex = 56;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // commitbtn
            // 
            this.commitbtn.Location = new System.Drawing.Point(461, 28);
            this.commitbtn.Name = "commitbtn";
            this.commitbtn.Size = new System.Drawing.Size(79, 23);
            this.commitbtn.TabIndex = 58;
            this.commitbtn.Text = "Commit";
            this.commitbtn.UseVisualStyleBackColor = true;
            this.commitbtn.Click += new System.EventHandler(this.commitbtn_Click);
            // 
            // CaseListBox
            // 
            this.CaseListBox.FormattingEnabled = true;
            this.CaseListBox.Location = new System.Drawing.Point(723, 25);
            this.CaseListBox.Name = "CaseListBox";
            this.CaseListBox.Size = new System.Drawing.Size(150, 24);
            this.CaseListBox.TabIndex = 59;
            this.CaseListBox.SelectedIndexChanged += new System.EventHandler(this.CaseListBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Uncommitted Cases:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.89079F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.10921F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.whatisnt, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.whereis, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.whatis, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.whereisnt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.whenis, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.whenisnt, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.extentis, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.extentisnt, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(774, 99);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 350);
            this.tableLayoutPanel1.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 3);
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(206, 5, 206, 5);
            this.label8.Size = new System.Drawing.Size(528, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "Problem Analysis";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(313, 32);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(70, 0, 105, 0);
            this.label7.Size = new System.Drawing.Size(231, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "IS NOT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(77, 32);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(90, 0, 118, 0);
            this.label4.Size = new System.Drawing.Size(230, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "IS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whatisnt
            // 
            this.whatisnt.Location = new System.Drawing.Point(313, 60);
            this.whatisnt.Name = "whatisnt";
            this.whatisnt.Size = new System.Drawing.Size(232, 73);
            this.whatisnt.TabIndex = 1;
            this.whatisnt.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(3, 57);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 30, 15, 38);
            this.label9.Size = new System.Drawing.Size(64, 84);
            this.label9.TabIndex = 5;
            this.label9.Text = "WHAT";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(3, 141);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 30, 7, 30);
            this.label10.Size = new System.Drawing.Size(66, 77);
            this.label10.TabIndex = 6;
            this.label10.Text = "WHERE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // whereis
            // 
            this.whereis.Location = new System.Drawing.Point(77, 144);
            this.whereis.Name = "whereis";
            this.whereis.Size = new System.Drawing.Size(230, 71);
            this.whereis.TabIndex = 0;
            this.whereis.Text = "";
            // 
            // whatis
            // 
            this.whatis.Location = new System.Drawing.Point(77, 60);
            this.whatis.Name = "whatis";
            this.whatis.Size = new System.Drawing.Size(230, 72);
            this.whatis.TabIndex = 7;
            this.whatis.Text = "";
            // 
            // whereisnt
            // 
            this.whereisnt.Location = new System.Drawing.Point(313, 144);
            this.whereisnt.Name = "whereisnt";
            this.whereisnt.Size = new System.Drawing.Size(232, 71);
            this.whereisnt.TabIndex = 8;
            this.whereisnt.Text = "";
            // 
            // whenis
            // 
            this.whenis.Location = new System.Drawing.Point(77, 221);
            this.whenis.Name = "whenis";
            this.whenis.Size = new System.Drawing.Size(230, 62);
            this.whenis.TabIndex = 9;
            this.whenis.Text = "";
            // 
            // whenisnt
            // 
            this.whenisnt.Location = new System.Drawing.Point(313, 221);
            this.whenisnt.Name = "whenisnt";
            this.whenisnt.Size = new System.Drawing.Size(232, 62);
            this.whenisnt.TabIndex = 10;
            this.whenisnt.Text = "";
            // 
            // extentis
            // 
            this.extentis.Location = new System.Drawing.Point(77, 289);
            this.extentis.Name = "extentis";
            this.extentis.Size = new System.Drawing.Size(230, 58);
            this.extentis.TabIndex = 11;
            this.extentis.Text = "";
            // 
            // extentisnt
            // 
            this.extentisnt.Location = new System.Drawing.Point(313, 289);
            this.extentisnt.Name = "extentisnt";
            this.extentisnt.Size = new System.Drawing.Size(230, 58);
            this.extentisnt.TabIndex = 12;
            this.extentisnt.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(3, 218);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 30, 14, 24);
            this.label11.Size = new System.Drawing.Size(64, 68);
            this.label11.TabIndex = 13;
            this.label11.Text = "WHEN";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(3, 286);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 15, 5, 30);
            this.label12.Size = new System.Drawing.Size(68, 62);
            this.label12.TabIndex = 14;
            this.label12.Text = "EXTENT";
            // 
            // meetingbtn
            // 
            this.meetingbtn.Location = new System.Drawing.Point(36, 281);
            this.meetingbtn.Name = "meetingbtn";
            this.meetingbtn.Size = new System.Drawing.Size(121, 29);
            this.meetingbtn.TabIndex = 62;
            this.meetingbtn.Text = "Create meeting";
            this.meetingbtn.UseVisualStyleBackColor = true;
            this.meetingbtn.Click += new System.EventHandler(this.meetingbtn_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(869, 729);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 63;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1374, 780);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.meetingbtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CaseListBox);
            this.Controls.Add(this.commitbtn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lbstopwatch);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbtimezone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.screencapturebtn);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.wrdbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.scrappad);
            this.Controls.Add(this.QuickAssist);
            this.Controls.Add(this.Soap_template);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SendToOneNote);
            this.Controls.Add(this.CaseNumberLabel);
            this.Controls.Add(this.CaseNumber);
            this.Controls.Add(this.SendToEscalation);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.SOAPNotes);
            this.Controls.Add(this.Reset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project 1Destiny";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.RichTextBox SOAPNotes;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button SendToEscalation;
        private System.Windows.Forms.TextBox CaseNumber;
        private System.Windows.Forms.Label CaseNumberLabel;
		private System.Windows.Forms.Button SendToOneNote;
		private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private RichTextBox Soap_template;
        private Button QuickAssist;
        private RichTextBox scrappad;
        private Button button2;
        private Label EST;
        private Timer timer1;
        private Label MST;
        private Timer timer2;
        private Label CST;
        private Timer timer3;
        private Label PST;
        private Timer timer4;
        private Label CET;
        private Label GMT;
        private Label ARAB;
        private Timer timer5;
        private Timer timer6;
        private Timer timer7;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Button wrdbtn;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton tbrFont;
        private ToolStripButton tspColor;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tbrBold;
        private ToolStripButton tbrItalic;
        private ToolStripButton tbrUnderline;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tbrLeft;
        private ToolStripButton tbrCenter;
        private ToolStripButton tbrRight;
        private FontDialog fontDialog1;
        private ColorDialog ColorDialog1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton insrtImage;
        private OpenFileDialog OpenFileDialog1;
        private ToolStripButton toolStripButton1;
        private Button screencapturebtn;
        private Label lblarea;
        private TextBox tbArea;
        private Button button3;
        private Label label5;
        private Label lbtimezone;
        private Label label6;
        private Button button5;
        private Button button6;
        private Timer timer8;
        private Label lbstopwatch;
        private Button button7;
        private Button commitbtn;
        private ComboBox CaseListBox;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox whereis;
        private RichTextBox whatisnt;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private RichTextBox whatis;
        private RichTextBox whereisnt;
        private RichTextBox whenis;
        private RichTextBox whenisnt;
        private RichTextBox extentis;
        private RichTextBox extentisnt;
        private Label label11;
        private Label label12;
        private Button meetingbtn;
        private RichTextBox richTextBox1;
    }
}

