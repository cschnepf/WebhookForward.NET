using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace WebhookForward.Configuration
{
	public class AuthenticationElement : ConfigurationElement
	{
		#region Properties

		[ConfigurationProperty("password", IsRequired = true)]
		[StringValidator(MinLength = 1, MaxLength = 60)]
		public String Password
		{
			get
			{
				return (String)this["password"];
			}
			set
			{
				this["password"] = value;
			}
		}

		[ConfigurationProperty("username", IsRequired = true)]
		[StringValidator(InvalidCharacters = "~!@#$%^&*()[]{}/;'\"|\\", MinLength = 1, MaxLength = 60)]
		public String Username
		{
			get
			{
				return (String)this["username"];
			}
			set
			{
				this["username"] = value;
			}
		}

		#endregion Properties
	}
}
