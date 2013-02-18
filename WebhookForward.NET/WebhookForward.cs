using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LoveSeat;

using WebhookForward.Configuration;
using WebhookForward.JSon;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebhookForward.NET
{
	public partial class WebhookForward : Form
	{
		#region Fields

		private CouchClient _client = null;
		private CouchDatabase _database = null;

		#endregion Fields

		#region Constructors

		public WebhookForward()
		{
			InitializeComponent();
		}

		#endregion Constructors

		#region Methods

		private void btnStart_Click(object sender, EventArgs e)
		{
			string databaseName = txtDatabase.Text;

			_client = new CouchClient(
				txtHost.Text,
				Int32.Parse(txtPort.Text),
				txtUsername.Text,
				txtPassword.Text,
				chkHttps.Checked,
				AuthenticationType.Basic);

			bool x = _client.HasDatabase(databaseName);
			_database = _client.GetDatabase(databaseName);

			EnableTimer(true);
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			EnableTimer(false);
		}

		private void EnableTimer(bool enable)
		{
			btnStart.Enabled = !enable;
			btnStop.Enabled = enable;
			tim_HookQuery.Enabled = enable;
		}

		private void tim_HookQuery_Tick(object sender, EventArgs e)
		{
			string key = null;
			var docs = _database.GetAllDocuments();

			foreach (var tokenKey in docs.Keys)
			{
				key = tokenKey.ToString();
				if (!key.StartsWith("_design") && !lstWebhooks.Items.Contains(key))
				{
					lstWebhooks.Items.Add(key);
				}
			}
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
			txtWebhookUrl.Text = defaultOptions.WebhookPostInformation.WebhookUrl;
		}

		#endregion Methods

		private void btnPost_Click(object sender, EventArgs e)
		{
			List<string> postedItems = new List<string>();

			foreach (var item in lstWebhooks.SelectedItems)
			{
				postedItems.Add(item.ToString());
			}

			foreach (var postedItem in postedItems)
			{
				WebhookDocument webhookDocument = _database.GetDocument<WebhookDocument>(postedItem.ToString());

				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(txtWebhookUrl.Text);
				request.Method = "POST";
				request.ContentType = "application/json; charset:utf-8";
				StreamWriter writer = new StreamWriter(request.GetRequestStream());
				JObject body = JObject.Parse(webhookDocument.req.body);
				writer.Write(body);
				writer.Close();
				HttpWebResponse response = request.GetResponse() as HttpWebResponse;
				if (response.StatusCode == HttpStatusCode.OK)
				{
					Delete(webhookDocument);
				}
			}
		}

		private void Delete(WebhookDocument doc)
		{
			_database.DeleteDocument(doc._id, doc._rev);
			lstWebhooks.Items.Remove(doc._id);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			List<string> removedItems = new List<string>();
			foreach (var item in lstWebhooks.SelectedItems)
			{
				removedItems.Add(item.ToString());
			}

			foreach (var removedItem in removedItems)
			{
				Delete(_database.GetDocument<WebhookDocument>(removedItem.ToString()));
			}
		}
	}
}