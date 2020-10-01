﻿using System;
using System.Collections.Generic;
using System.Data;

namespace NetCoreApp.Models
{
	public partial class Container
	{

		public static List<Container> Get()
		{
			string query = $"Select * From [Container]";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Container>(table);
		}

		public static Container Get(Guid id)
		{
			string query = $"Select * From [Container] Where ID = '{id}'";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Container>(table)[0];
		}

		public static void Insert(string name)
		{
			string query = $"Insert Into [Container] Values (default, '{name}')";
			DataAccess.Exec(query);
		}

		public static void Update(string id, string name)
		{
			string query = $"Update [Container] Set Name = '{name}' Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static void Delete(string id)
		{
			string query = $"Delete From [Container] Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static bool Exist(Guid id)
		{
			string query = $"Select Count(*) From [Container] Where ID = '{id}'";
			return (DataAccess.Find(query) > 0);
		}

	}
}
