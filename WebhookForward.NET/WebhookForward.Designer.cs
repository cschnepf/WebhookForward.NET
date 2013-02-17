namespace WebhookForward.NET
{
	partial class WebhookForward
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
			this.txtWebhookUrl = new System.Windows.Forms.TextBox();
			this.lblWebhookUrl = new System.Windows.Forms.Label();
			this.lblCouchDBHost = new System.Windows.Forms.Label();
			this.chkPostAll = new System.Windows.Forms.CheckBox();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPost = new System.Windows.Forms.Button();
			this.lstWebhooks = new System.Windows.Forms.ListBox();
			this.txtHost = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.chkHttps = new System.Windows.Forms.CheckBox();
			this.lblPort = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblDatabase = new System.Windows.Forms.Label();
			this.txtDatabase = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtWebhookUrl
			// 
			this.txtWebhookUrl.Location = new System.Drawing.Point(129, 177);
			this.txtWebhookUrl.Name = "txtWebhookUrl";
			this.txtWebhookUrl.Size = new System.Drawing.Size(259, 20);
			this.txtWebhookUrl.TabIndex = 19;
			// 
			// lblWebhookUrl
			// 
			this.lblWebhookUrl.AutoSize = true;
			this.lblWebhookUrl.Location = new System.Drawing.Point(24, 184);
			this.lblWebhookUrl.Name = "lblWebhookUrl";
			this.lblWebhookUrl.Size = new System.Drawing.Size(70, 13);
			this.lblWebhookUrl.TabIndex = 18;
			this.lblWebhookUrl.Text = "Webhook Url";
			// 
			// lblCouchDBHost
			// 
			this.lblCouchDBHost.AutoSize = true;
			this.lblCouchDBHost.Location = new System.Drawing.Point(24, 23);
			this.lblCouchDBHost.Name = "lblCouchDBHost";
			this.lblCouchDBHost.Size = new System.Drawing.Size(81, 13);
			this.lblCouchDBHost.TabIndex = 17;
			this.lblCouchDBHost.Text = "CouchDB Host:";
			// 
			// chkPostAll
			// 
			this.chkPostAll.AutoSize = true;
			this.chkPostAll.Location = new System.Drawing.Point(30, 412);
			this.chkPostAll.Name = "chkPostAll";
			this.chkPostAll.Size = new System.Drawing.Size(61, 17);
			this.chkPostAll.TabIndex = 16;
			this.chkPostAll.Text = "Post &All";
			this.chkPostAll.UseVisualStyleBackColor = true;
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(193, 210);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 15;
			this.btnStop.Text = "S&top";
			this.btnStop.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(193, 406);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 14;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnPost
			// 
			this.btnPost.Location = new System.Drawing.Point(112, 406);
			this.btnPost.Name = "btnPost";
			this.btnPost.Size = new System.Drawing.Size(75, 23);
			this.btnPost.TabIndex = 13;
			this.btnPost.Text = "&Post";
			this.btnPost.UseVisualStyleBackColor = true;
			// 
			// lstWebhooks
			// 
			this.lstWebhooks.FormattingEnabled = true;
			this.lstWebhooks.Location = new System.Drawing.Point(24, 239);
			this.lstWebhooks.Name = "lstWebhooks";
			this.lstWebhooks.Size = new System.Drawing.Size(364, 160);
			this.lstWebhooks.TabIndex = 12;
			// 
			// txtHost
			// 
			this.txtHost.Location = new System.Drawing.Point(112, 20);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new System.Drawing.Size(124, 20);
			this.txtHost.TabIndex = 11;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(112, 210);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 10;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// chkHttps
			// 
			this.chkHttps.AutoSize = true;
			this.chkHttps.Location = new System.Drawing.Point(254, 22);
			this.chkHttps.Name = "chkHttps";
			this.chkHttps.Size = new System.Drawing.Size(73, 17);
			this.chkHttps.TabIndex = 20;
			this.chkHttps.Text = "Use Https";
			this.chkHttps.UseVisualStyleBackColor = true;
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(76, 50);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(29, 13);
			this.lblPort.TabIndex = 21;
			this.lblPort.Text = "Port:";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(112, 47);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(45, 20);
			this.txtPort.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 23;
			this.label1.Text = "Username:";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(112, 73);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(100, 20);
			this.txtUsername.TabIndex = 24;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(112, 98);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(100, 20);
			this.txtPassword.TabIndex = 26;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(47, 101);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 25;
			this.lblPassword.Text = "Password:";
			// 
			// lblDatabase
			// 
			this.lblDatabase.AutoSize = true;
			this.lblDatabase.Location = new System.Drawing.Point(47, 126);
			this.lblDatabase.Name = "lblDatabase";
			this.lblDatabase.Size = new System.Drawing.Size(56, 13);
			this.lblDatabase.TabIndex = 27;
			this.lblDatabase.Text = "Database:";
			// 
			// txtDatabase
			// 
			this.txtDatabase.Location = new System.Drawing.Point(112, 125);
			this.txtDatabase.Name = "txtDatabase";
			this.txtDatabase.Size = new System.Drawing.Size(100, 20);
			this.txtDatabase.TabIndex = 28;
			// 
			// WebhookForward
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 551);
			this.Controls.Add(this.txtDatabase);
			this.Controls.Add(this.lblDatabase);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.chkHttps);
			this.Controls.Add(this.txtWebhookUrl);
			this.Controls.Add(this.lblWebhookUrl);
			this.Controls.Add(this.lblCouchDBHost);
			this.Controls.Add(this.chkPostAll);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnPost);
			this.Controls.Add(this.lstWebhooks);
			this.Controls.Add(this.txtHost);
			this.Controls.Add(this.btnStart);
			this.Name = "WebhookForward";
			this.Text = "Webhook Forward.NET";
			this.Load += new System.EventHandler(this.WebhookForward_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtWebhookUrl;
		private System.Windows.Forms.Label lblWebhookUrl;
		private System.Windows.Forms.Label lblCouchDBHost;
		private System.Windows.Forms.CheckBox chkPostAll;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnPost;
		private System.Windows.Forms.ListBox lstWebhooks;
		private System.Windows.Forms.TextBox txtHost;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.CheckBox chkHttps;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblDatabase;
		private System.Windows.Forms.TextBox txtDatabase;
	}
}

