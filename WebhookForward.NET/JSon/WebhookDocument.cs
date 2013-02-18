using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WebhookForward.JSon
{
	public class Other
	{
		public int data_size { get; set; }
	}

	public class Info
	{
		public string update_seq { get; set; }
		public string db_name { get; set; }
		public int purge_seq { get; set; }
		public Other other { get; set; }
		public int doc_del_count { get; set; }
		public int doc_count { get; set; }
		public int disk_size { get; set; }
		public int disk_format_version { get; set; }
		public bool compact_running { get; set; }
		public string instance_start_time { get; set; }
	}

	public class Query
	{
	}

	public class Headers
	{
		public string Accept { get; set; }
		[JsonProperty(PropertyName = "Accept-Encoding")]
		public string AcceptEncoding { get; set; }
		public string Authorization { get; set; }
		public string Connection { get; set; }
		[JsonProperty(PropertyName = "Content-Length")]
		public string ContentLength { get; set; }
		[JsonProperty(PropertyName = "Content-Type")]
		public string ContentType { get; set; }
		public string Host { get; set; }
		[JsonProperty(PropertyName = "User-Agent")]
		public string UserAgent { get; set; }
		[JsonProperty(PropertyName = "X-Forwarded-For")]
		public string ForwardedFor { get; set; }
	}

	public class HttpForm
	{
	}

	public class Cookie
	{
	}

	public class UserCtx
	{
		public string db { get; set; }
		public string name { get; set; }
		public List<string> roles { get; set; }
	}

	public class Req
	{
		public Info info { get; set; }
		public string uuid { get; set; }
		public object id { get; set; }
		public string method { get; set; }
		public List<string> path { get; set; }
		public Query query { get; set; }
		public Headers headers { get; set; }
		public string body { get; set; }
		public string peer { get; set; }
		[JsonProperty(PropertyName = "Form")]
		public HttpForm form { get; set; }
		public Cookie cookie { get; set; }
		public UserCtx userCtx { get; set; }
	}

	public class WebhookDocument
	{
		public string _id { get; set; }
		public string _rev { get; set; }
		public string type { get; set; }
		public Req req { get; set; }
		public string created_at { get; set; }
	}
}
