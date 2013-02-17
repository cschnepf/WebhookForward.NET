using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LoveSeat;
using WebhookForward.Configuration;
using System.Configuration;

namespace WebhookForward.NET
{
	public partial class WebhookForward : Form
	{
		public WebhookForward()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			string databaseName = txtDatabase.Text;

			var client = new CouchClient(
				txtHost.Text,
				Int32.Parse(txtPort.Text),
				txtUsername.Text,
				txtPassword.Text,
				chkHttps.Checked,
				AuthenticationType.Basic);

			bool x = client.HasDatabase(databaseName);
			var db = client.GetDatabase(databaseName);

			var docs = db.GetAllDocuments();
			foreach (var doc in docs.Docs)
			{
				lstWebhooks.Items.Add(doc);
			}


			/// https://tuneuplog:@tuneuplog.cloudant.com/hooks//_design/hookforward/_update/capture

			//try
			//{
			//	XDocument feedXml = XDocument.Load(txtHookDBUrl.Text);
			//feeds = from feed in feedXml.Descendants("item")
			//select new RSS
			//{
			//    Title = feed.Element("title").Value,
			//    Link = feed.Element("link").Value,
			//    Description = Regex.Match(feed.Element("description").Value, @"^.{1,180}\b(?<!\s)").Value
			//};
			//}
			//catch (Exception ex)
			//{
			//    //Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
			//}

			//return Json(feeds, JsonRequestBehavior.AllowGet);
		}

		private void WebhookForward_Load(object sender, EventArgs e)
		{
			DefaultOptionsSection defaultOptions = 
				(DefaultOptionsSection)ConfigurationManager.GetSection("defaultOptionsGroup/defaultOptions");

			txtHost.Text = defaultOptions.ServerInformation.Host;
			chkHttps.Checked = defaultOptions.ServerInformation.UseHttps;
			txtPort.Text = defaultOptions.ServerInformation.Port.ToString();
			txtUsername.Text = defaultOptions.Authentication.Username;
			txtPassword.Text = defaultOptions.Authentication.Password;
			txtDatabase.Text = defaultOptions.Database.Name;
		}
	}
}
