using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Components
{
	public class Bootstrap
	{

		public static string GetInputTextFormControl(string id, string label, string name)
		{
			string component = 
				@"<div class=""form-group"">" +
				$"<label for=\"{id}\">{label}</label>" +
				$"<input type=\"text\" id=\"{id}\" class\"form-control\" name=\"{name}\"/>" +
				"</div>";
			return component;
		}

	}
}
