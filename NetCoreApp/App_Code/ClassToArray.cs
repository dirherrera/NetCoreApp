using System;
using System.Reflection;

namespace NetCoreApp.App_Code
{

	public class ClassToArray
	{

		public static Array ToArray<T>(T cls)
		{
			PropertyInfo[] properties = typeof(T).GetProperties();
			Array array = Array.CreateInstance(typeof(T), properties.Length);

			return array;
		}

	}
}
