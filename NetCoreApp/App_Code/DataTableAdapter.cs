using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace NetCoreApp
{
	public class DataTableAdapter
	{
		public static List<T> Get<T>(DataTable table)
		{
			List<T> list = new List<T>();
			PropertyInfo[] properties = typeof(T).GetProperties();
			foreach (DataRow row in table.Rows)
			{
				var item = Activator.CreateInstance<T>();
				foreach (DataColumn col in table.Columns)
				{
					foreach (PropertyInfo property in properties)
					{
						if (property.Name == col.ColumnName) {
							var value = GetColumnValueSafe<T>(row[col.ColumnName]);
							property.SetValue(item, value, null);
							break;
						}
					}
				}
				list.Add(item);
			}
			return list;
		}

		public static object GetColumnValueSafe<T>(object col)
		{
			if (col is DBNull)
			{
				col = default(T);
			}
			return col;
		}

	}
}