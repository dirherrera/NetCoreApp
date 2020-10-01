using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class DeliveryOrder
	{

		public static List<DeliveryOrder> Get()
		{
			string query = $"Select * From [DeliveryOrder]";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<DeliveryOrder>(table);
		}

		public static DeliveryOrder Get(string id)
		{
			string query = $"Select * From [DeliveryOrder] Where ID = '{id}'";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<DeliveryOrder>(table)[0];
		}

		public static void Insert(string reference, Guid customer, Guid vessel, Guid container, string weight, string arrivalDate)
		{
			string query = $"Insert Into [DeliveryOrder] Values (default, '{reference}', '{customer}', '{vessel}', '{container}', '{weight}'," +
				$"'{arrivalDate}', GETDATE())";
			DataAccess.Exec(query);
		}

		public static void Edit(string id, string reference, string customer, string vessel, string container, string weight, string arrivalDate)
		{
			string query = $"Update [DeliveryOrder] Set Reference = '{reference}', Customer = '{customer}', Vessel = '{vessel}'," +
				$" Container = '{container}', Weight = '{weight}', ArrivalDate = '{arrivalDate}' Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static void Delete(string id)
		{
			string query = $"Delete From [DeliveryOrder] Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static bool Duplicate(string reference)
		{
			bool exist = true;
			string query = $"Select Count(*) From [DeliveryOrder] WHERE Reference = '{reference}'";
			exist = (DataAccess.Find(query) >= 1);
			return exist;
		}

	}
}
