namespace FaucetCryptoBot.UI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnBrowserQuit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTester = new System.Windows.Forms.Button();
            this.grpbxAdsInfo = new System.Windows.Forms.GroupBox();
            this.lblAdsInfoPtcAds = new System.Windows.Forms.Label();
            this.lblAdsInfoArchievements = new System.Windows.Forms.Label();
            this.tbxAdsInfoPtcAds = new System.Windows.Forms.TextBox();
            this.tbxAdsInfoAchievements = new System.Windows.Forms.TextBox();
            this.lblAdsInfoShortLinks = new System.Windows.Forms.Label();
            this.tbxAdsInfoShortLinks = new System.Windows.Forms.TextBox();
            this.lblAdsInfoReadyToClaim = new System.Windows.Forms.Label();
            this.tbxAdsInfoReadyToClaim = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbxApiAuthorization = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApiSetToken = new System.Windows.Forms.Button();
            this.grpbxApiService = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpbxServices = new System.Windows.Forms.GroupBox();
            this.btnServicesStop = new System.Windows.Forms.Button();
            this.btnServicesStart = new System.Windows.Forms.Button();
            this.lstbxServices = new System.Windows.Forms.CheckedListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxBalanceWon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBalanceCurrent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBalanceFirst = new System.Windows.Forms.TextBox();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.lstbxLogs = new System.Windows.Forms.ListBox();
            this.grpbxAdsInfo.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.grpbxApiService.SuspendLayout();
            this.grpbxServices.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(11, 63);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(185, 30);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_ClickAsync);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 12);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Eposta";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(203, 12);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(36, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(11, 33);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(185, 22);
            this.tbxEmail.TabIndex = 3;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(206, 33);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(185, 22);
            this.tbxPassword.TabIndex = 4;
            // 
            // btnBrowserQuit
            // 
            this.btnBrowserQuit.Enabled = false;
            this.btnBrowserQuit.Location = new System.Drawing.Point(206, 63);
            this.btnBrowserQuit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBrowserQuit.Name = "btnBrowserQuit";
            this.btnBrowserQuit.Size = new System.Drawing.Size(185, 30);
            this.btnBrowserQuit.TabIndex = 7;
            this.btnBrowserQuit.Text = "Tarayıcıyı Kapat";
            this.btnBrowserQuit.UseVisualStyleBackColor = true;
            this.btnBrowserQuit.Click += new System.EventHandler(this.btnBrowserQuit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTester
            // 
            this.btnTester.Location = new System.Drawing.Point(473, 13);
            this.btnTester.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTester.Name = "btnTester";
            this.btnTester.Size = new System.Drawing.Size(118, 30);
            this.btnTester.TabIndex = 8;
            this.btnTester.Text = "Tester";
            this.btnTester.UseVisualStyleBackColor = true;
            this.btnTester.Click += new System.EventHandler(this.btnTester_Click);
            // 
            // grpbxAdsInfo
            // 
            this.grpbxAdsInfo.Controls.Add(this.lblAdsInfoPtcAds);
            this.grpbxAdsInfo.Controls.Add(this.lblAdsInfoArchievements);
            this.grpbxAdsInfo.Controls.Add(this.tbxAdsInfoPtcAds);
            this.grpbxAdsInfo.Controls.Add(this.tbxAdsInfoAchievements);
            this.grpbxAdsInfo.Controls.Add(this.lblAdsInfoShortLinks);
            this.grpbxAdsInfo.Controls.Add(this.tbxAdsInfoShortLinks);
            this.grpbxAdsInfo.Controls.Add(this.lblAdsInfoReadyToClaim);
            this.grpbxAdsInfo.Controls.Add(this.tbxAdsInfoReadyToClaim);
            this.grpbxAdsInfo.Location = new System.Drawing.Point(13, 68);
            this.grpbxAdsInfo.Name = "grpbxAdsInfo";
            this.grpbxAdsInfo.Size = new System.Drawing.Size(379, 80);
            this.grpbxAdsInfo.TabIndex = 11;
            this.grpbxAdsInfo.TabStop = false;
            this.grpbxAdsInfo.Text = "Detaylar";
            // 
            // lblAdsInfoPtcAds
            // 
            this.lblAdsInfoPtcAds.AutoSize = true;
            this.lblAdsInfoPtcAds.Location = new System.Drawing.Point(297, 25);
            this.lblAdsInfoPtcAds.Name = "lblAdsInfoPtcAds";
            this.lblAdsInfoPtcAds.Size = new System.Drawing.Size(52, 17);
            this.lblAdsInfoPtcAds.TabIndex = 7;
            this.lblAdsInfoPtcAds.Text = "PtcAds";
            // 
            // lblAdsInfoArchievements
            // 
            this.lblAdsInfoArchievements.AutoSize = true;
            this.lblAdsInfoArchievements.Location = new System.Drawing.Point(225, 25);
            this.lblAdsInfoArchievements.Name = "lblAdsInfoArchievements";
            this.lblAdsInfoArchievements.Size = new System.Drawing.Size(40, 17);
            this.lblAdsInfoArchievements.TabIndex = 6;
            this.lblAdsInfoArchievements.Text = "Archi";
            // 
            // tbxAdsInfoPtcAds
            // 
            this.tbxAdsInfoPtcAds.Location = new System.Drawing.Point(300, 45);
            this.tbxAdsInfoPtcAds.Name = "tbxAdsInfoPtcAds";
            this.tbxAdsInfoPtcAds.ReadOnly = true;
            this.tbxAdsInfoPtcAds.Size = new System.Drawing.Size(69, 22);
            this.tbxAdsInfoPtcAds.TabIndex = 5;
            this.tbxAdsInfoPtcAds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAdsInfoAchievements
            // 
            this.tbxAdsInfoAchievements.Location = new System.Drawing.Point(225, 45);
            this.tbxAdsInfoAchievements.Name = "tbxAdsInfoAchievements";
            this.tbxAdsInfoAchievements.ReadOnly = true;
            this.tbxAdsInfoAchievements.Size = new System.Drawing.Size(69, 22);
            this.tbxAdsInfoAchievements.TabIndex = 4;
            this.tbxAdsInfoAchievements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAdsInfoShortLinks
            // 
            this.lblAdsInfoShortLinks.AutoSize = true;
            this.lblAdsInfoShortLinks.Location = new System.Drawing.Point(147, 25);
            this.lblAdsInfoShortLinks.Name = "lblAdsInfoShortLinks";
            this.lblAdsInfoShortLinks.Size = new System.Drawing.Size(72, 17);
            this.lblAdsInfoShortLinks.TabIndex = 3;
            this.lblAdsInfoShortLinks.Text = "ShortLinks";
            // 
            // tbxAdsInfoShortLinks
            // 
            this.tbxAdsInfoShortLinks.Location = new System.Drawing.Point(150, 45);
            this.tbxAdsInfoShortLinks.Name = "tbxAdsInfoShortLinks";
            this.tbxAdsInfoShortLinks.ReadOnly = true;
            this.tbxAdsInfoShortLinks.Size = new System.Drawing.Size(69, 22);
            this.tbxAdsInfoShortLinks.TabIndex = 2;
            this.tbxAdsInfoShortLinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAdsInfoReadyToClaim
            // 
            this.lblAdsInfoReadyToClaim.AutoSize = true;
            this.lblAdsInfoReadyToClaim.Location = new System.Drawing.Point(7, 25);
            this.lblAdsInfoReadyToClaim.Name = "lblAdsInfoReadyToClaim";
            this.lblAdsInfoReadyToClaim.Size = new System.Drawing.Size(100, 17);
            this.lblAdsInfoReadyToClaim.TabIndex = 1;
            this.lblAdsInfoReadyToClaim.Text = "Ready to Claim";
            // 
            // tbxAdsInfoReadyToClaim
            // 
            this.tbxAdsInfoReadyToClaim.Location = new System.Drawing.Point(10, 45);
            this.tbxAdsInfoReadyToClaim.Name = "tbxAdsInfoReadyToClaim";
            this.tbxAdsInfoReadyToClaim.ReadOnly = true;
            this.tbxAdsInfoReadyToClaim.Size = new System.Drawing.Size(134, 22);
            this.tbxAdsInfoReadyToClaim.TabIndex = 0;
            this.tbxAdsInfoReadyToClaim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 330);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(434, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Durum:";
            // 
            // toolStatusLabel
            // 
            this.toolStatusLabel.Name = "toolStatusLabel";
            this.toolStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(473, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(118, 96);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // tbxApiAuthorization
            // 
            this.tbxApiAuthorization.Location = new System.Drawing.Point(15, 44);
            this.tbxApiAuthorization.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxApiAuthorization.Name = "tbxApiAuthorization";
            this.tbxApiAuthorization.Size = new System.Drawing.Size(352, 22);
            this.tbxApiAuthorization.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Authorization";
            // 
            // btnApiSetToken
            // 
            this.btnApiSetToken.Location = new System.Drawing.Point(15, 74);
            this.btnApiSetToken.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnApiSetToken.Name = "btnApiSetToken";
            this.btnApiSetToken.Size = new System.Drawing.Size(352, 30);
            this.btnApiSetToken.TabIndex = 20;
            this.btnApiSetToken.Text = "Api Servis Bilgilerini Tanımla";
            this.btnApiSetToken.UseVisualStyleBackColor = true;
            this.btnApiSetToken.Click += new System.EventHandler(this.btnApiSetToken_Click);
            // 
            // grpbxApiService
            // 
            this.grpbxApiService.Controls.Add(this.label2);
            this.grpbxApiService.Controls.Add(this.btnApiSetToken);
            this.grpbxApiService.Controls.Add(this.tbxApiAuthorization);
            this.grpbxApiService.Enabled = false;
            this.grpbxApiService.Location = new System.Drawing.Point(11, 143);
            this.grpbxApiService.Name = "grpbxApiService";
            this.grpbxApiService.Size = new System.Drawing.Size(380, 117);
            this.grpbxApiService.TabIndex = 21;
            this.grpbxApiService.TabStop = false;
            this.grpbxApiService.Text = "Api Servis";
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(12, 97);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(379, 43);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Bekleniyor..";
            // 
            // grpbxServices
            // 
            this.grpbxServices.Controls.Add(this.btnServicesStop);
            this.grpbxServices.Controls.Add(this.btnServicesStart);
            this.grpbxServices.Controls.Add(this.lstbxServices);
            this.grpbxServices.Location = new System.Drawing.Point(13, 154);
            this.grpbxServices.Name = "grpbxServices";
            this.grpbxServices.Size = new System.Drawing.Size(379, 107);
            this.grpbxServices.TabIndex = 23;
            this.grpbxServices.TabStop = false;
            this.grpbxServices.Text = "Reklam Servisleri";
            // 
            // btnServicesStop
            // 
            this.btnServicesStop.BackColor = System.Drawing.Color.IndianRed;
            this.btnServicesStop.Enabled = false;
            this.btnServicesStop.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnServicesStop.FlatAppearance.BorderSize = 2;
            this.btnServicesStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicesStop.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServicesStop.ForeColor = System.Drawing.Color.White;
            this.btnServicesStop.Location = new System.Drawing.Point(206, 61);
            this.btnServicesStop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnServicesStop.Name = "btnServicesStop";
            this.btnServicesStop.Size = new System.Drawing.Size(163, 30);
            this.btnServicesStop.TabIndex = 12;
            this.btnServicesStop.Text = "Durdur";
            this.btnServicesStop.UseVisualStyleBackColor = false;
            this.btnServicesStop.Click += new System.EventHandler(this.btnServicesStop_Click);
            // 
            // btnServicesStart
            // 
            this.btnServicesStart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnServicesStart.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnServicesStart.FlatAppearance.BorderSize = 2;
            this.btnServicesStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicesStart.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServicesStart.ForeColor = System.Drawing.Color.White;
            this.btnServicesStart.Location = new System.Drawing.Point(206, 23);
            this.btnServicesStart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnServicesStart.Name = "btnServicesStart";
            this.btnServicesStart.Size = new System.Drawing.Size(163, 30);
            this.btnServicesStart.TabIndex = 11;
            this.btnServicesStart.Text = "Başlat";
            this.btnServicesStart.UseVisualStyleBackColor = false;
            this.btnServicesStart.Click += new System.EventHandler(this.btnServicesStart_Click);
            // 
            // lstbxServices
            // 
            this.lstbxServices.FormattingEnabled = true;
            this.lstbxServices.Items.AddRange(new object[] {
            "Ready to Claim",
            "ShortLinks",
            "Archievements",
            "Ptc Ads"});
            this.lstbxServices.Location = new System.Drawing.Point(10, 23);
            this.lstbxServices.Name = "lstbxServices";
            this.lstbxServices.Size = new System.Drawing.Size(188, 72);
            this.lstbxServices.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLogin);
            this.tabControl.Controls.Add(this.tabServices);
            this.tabControl.Controls.Add(this.tabLogs);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(413, 306);
            this.tabControl.TabIndex = 24;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.lblEmail);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.lblStatus);
            this.tabLogin.Controls.Add(this.lblPassword);
            this.tabLogin.Controls.Add(this.grpbxApiService);
            this.tabLogin.Controls.Add(this.tbxEmail);
            this.tabLogin.Controls.Add(this.tbxPassword);
            this.tabLogin.Controls.Add(this.btnBrowserQuit);
            this.tabLogin.Location = new System.Drawing.Point(4, 26);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(405, 276);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Giriş Yap";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.label4);
            this.tabServices.Controls.Add(this.tbxBalanceWon);
            this.tabServices.Controls.Add(this.label3);
            this.tabServices.Controls.Add(this.tbxBalanceCurrent);
            this.tabServices.Controls.Add(this.label1);
            this.tabServices.Controls.Add(this.grpbxAdsInfo);
            this.tabServices.Controls.Add(this.tbxBalanceFirst);
            this.tabServices.Controls.Add(this.grpbxServices);
            this.tabServices.Location = new System.Drawing.Point(4, 26);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(405, 276);
            this.tabServices.TabIndex = 1;
            this.tabServices.Text = "Reklam Servisleri";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kazanılan";
            // 
            // tbxBalanceWon
            // 
            this.tbxBalanceWon.Location = new System.Drawing.Point(229, 40);
            this.tbxBalanceWon.Name = "tbxBalanceWon";
            this.tbxBalanceWon.ReadOnly = true;
            this.tbxBalanceWon.Size = new System.Drawing.Size(102, 22);
            this.tbxBalanceWon.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mevcut Kazanç";
            // 
            // tbxBalanceCurrent
            // 
            this.tbxBalanceCurrent.Location = new System.Drawing.Point(121, 40);
            this.tbxBalanceCurrent.Name = "tbxBalanceCurrent";
            this.tbxBalanceCurrent.ReadOnly = true;
            this.tbxBalanceCurrent.Size = new System.Drawing.Size(102, 22);
            this.tbxBalanceCurrent.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "İlk Kazanç";
            // 
            // tbxBalanceFirst
            // 
            this.tbxBalanceFirst.Location = new System.Drawing.Point(13, 40);
            this.tbxBalanceFirst.Name = "tbxBalanceFirst";
            this.tbxBalanceFirst.ReadOnly = true;
            this.tbxBalanceFirst.Size = new System.Drawing.Size(102, 22);
            this.tbxBalanceFirst.TabIndex = 25;
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.lstbxLogs);
            this.tabLogs.Location = new System.Drawing.Point(4, 26);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(405, 276);
            this.tabLogs.TabIndex = 2;
            this.tabLogs.Text = "İşlem Kaydı";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // lstbxLogs
            // 
            this.lstbxLogs.FormattingEnabled = true;
            this.lstbxLogs.ItemHeight = 17;
            this.lstbxLogs.Location = new System.Drawing.Point(6, 7);
            this.lstbxLogs.Name = "lstbxLogs";
            this.lstbxLogs.Size = new System.Drawing.Size(393, 259);
            this.lstbxLogs.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 352);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnTester);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaucetCrypto Bot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grpbxAdsInfo.ResumeLayout(false);
            this.grpbxAdsInfo.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grpbxApiService.ResumeLayout(false);
            this.grpbxApiService.PerformLayout();
            this.grpbxServices.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            this.tabLogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnBrowserQuit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTester;
        private System.Windows.Forms.GroupBox grpbxAdsInfo;
        private System.Windows.Forms.Label lblAdsInfoReadyToClaim;
        private System.Windows.Forms.TextBox tbxAdsInfoReadyToClaim;
        private System.Windows.Forms.Label lblAdsInfoShortLinks;
        private System.Windows.Forms.TextBox tbxAdsInfoShortLinks;
        private System.Windows.Forms.TextBox tbxAdsInfoPtcAds;
        private System.Windows.Forms.TextBox tbxAdsInfoAchievements;
        private System.Windows.Forms.Label lblAdsInfoPtcAds;
        private System.Windows.Forms.Label lblAdsInfoArchievements;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tbxApiAuthorization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApiSetToken;
        private System.Windows.Forms.GroupBox grpbxApiService;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpbxServices;
        private System.Windows.Forms.CheckedListBox lstbxServices;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.Button btnServicesStart;
        private System.Windows.Forms.Button btnServicesStop;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.ListBox lstbxLogs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxBalanceWon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBalanceCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBalanceFirst;
    }
}

