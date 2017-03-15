﻿using System;
using System.IO;
using System.Reflection;

namespace Unicorn.ControlPanel.Headings
{
	public class HeadingService
	{
		static readonly Random Random = new Random();

		private static readonly string[] HtmlChoices = {
			"Unicorn.ControlPanel.Headings.Unicorn.html",
			"Unicorn.ControlPanel.Headings.Unicorn.svg.html",
			"Unicorn.ControlPanel.Headings.Unicorn2.svg.html",
			"Unicorn.ControlPanel.Headings.Unicorn3.svg.html"
		};

		public string GetHeadingHtml()
		{
			// heh heh :)
			if (DateTime.Today.Month == 4 && DateTime.Today.Day == 1) return ReadResource("Unicorn.ControlPanel.Headings.April.svg.html");

			var headerIndex = Random.Next(0, HtmlChoices.Length);

			return ReadResource(HtmlChoices[headerIndex]);
		}

		public string GetControlPanelHeadingHtml()
		{
			return ReadResource("Unicorn.ControlPanel.Headings.ControlPanel.svg.html");
		}

		protected virtual string ReadResource(string name)
		{
			var assembly = Assembly.GetExecutingAssembly();

			using (Stream stream = assembly.GetManifestResourceStream(name))
			using (StreamReader reader = new StreamReader(stream))
			{
				return reader.ReadToEnd();
			}
		}
	}
}
