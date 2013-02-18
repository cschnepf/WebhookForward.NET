﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace WebhookForward.Configuration
{
	public class WebhookPostInformation : ConfigurationElement
	{
		[ConfigurationProperty("webhookUrl", IsRequired = false)]
		public String WebhookUrl
		{
			get
			{
				return (String)this["webhookUrl"];
			}
			set
			{
				this["webhookUrl"] = value;
			}
		}
	}
}
