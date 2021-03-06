﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace WebhookForward.Configuration
{
	public class DatabaseElement : ConfigurationElement
	{
		#region Properties

		[ConfigurationProperty("name", IsRequired = false)]
		public String Name
		{
			get
			{
				return (String)this["name"];
			}
			set
			{
				this["name"] = value;
			}
		}

		#endregion Properties
	}
}
