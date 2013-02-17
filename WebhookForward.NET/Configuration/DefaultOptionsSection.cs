using System;
using System.Collections;
using System.Configuration;
using System.Text;
using System.Xml;

namespace WebhookForward.Configuration
{
	public class DefaultOptionsSection : ConfigurationSection
	{
		#region Properties

		[ConfigurationProperty("authentication")]
		public AuthenticationElement Authentication
		{
			get
			{
				return (AuthenticationElement)this["authentication"];
			}
			set
			{
				this["authentication"] = value;
			}
		}

		[ConfigurationProperty("database")]
		public DatabaseElement Database
		{
			get
			{
				return (DatabaseElement)this["database"];
			}
			set
			{
				this["database"] = value;
			}
		}

		[ConfigurationProperty("serverInformation")]
		public ServerInformationElement ServerInformation
		{
			get
			{
				return (ServerInformationElement)this["serverInformation"];
			}
			set
			{
				this["serverInformation"] = value;
			}
		}

		#endregion Properties
	}
}