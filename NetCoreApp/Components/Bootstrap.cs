using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

	}
}
