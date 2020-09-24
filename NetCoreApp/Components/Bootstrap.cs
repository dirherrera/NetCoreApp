using System;
using System.Reflection;

namespace NetCoreApp.Components
{
	public class Bootstrap
	{

		public static void Convert<T> ()
		{
			var model = Activator.CreateInstance<T>();
			PropertyInfo[] properties = typeof(T).GetProperties();
			foreach (PropertyInfo property in properties)
			{
				string name = property.Name;
				Type type = property.PropertyType;

			}
		}

		private static void GetComponent()
		{

		}

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
