using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetCoreApp.Components
{
	public class Bootstrap
	{

		public static Component GetInputTextFormControl(string id, string label, string name)
		{
			Component component = new Component();
			component.Content =
				@"<div class=""form-group"">" +
				$"<label for=\"{id}\">{label}</label>" +
				$"<input type=\"text\" id=\"{id}\" class\"form-control\" name=\"{name}\"/>" +
				"</div>";
			return component;
		}

		public static Component GetSelectFormControl(string id, string name, List<Dictionary<string, string>> list)
		{
			Component component = new Component();
			component.Content =
				@"<div class=""form-group"">" +
				$"<select id=\"{id}\" class\"form-control\" string=\"{name}\">";

			foreach (Dictionary<string, string> item in list)
			{
				component.Content += $"<option value\"{item["value"]}\">{item["name"]}</option>";
			}
			component.Content += 
				"</select>" +
				"</div>";
			return component;
		}

	}
}
