using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace WebhookForward.Configuration
{
	public class ServerInformationElement : ConfigurationElement
	{
		#region Properties

		[ConfigurationProperty("host", IsRequired = false)]
		public String Host
		{
			get
			{
				return (String)this["host"];
			}
			set
			{
				this["host"] = value;
			}
		}

		[ConfigurationProperty("port", DefaultValue = "80", IsRequired = false)]
		[IntegerValidator]
		public int Port
		{
			get
			{
				return (int)this["port"];
			}
			set
			{
				this["port"] = value;
			}
		}

		[ConfigurationProperty("useHttps", DefaultValue = "false", IsRequired = false)]
		public bool UseHttps
		{
			get
			{
				return (bool)this["useHttps"];
			}
			set
			{
				this["useHttps"] = value;
			}
		}

		#endregion Properties
	}
}
