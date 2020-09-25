using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class DeliveryOrder
	{

		public DeliveryOrder GetDeliveryOrder(string id)
		{
			string query = $"Select * From [DeliveryOrder] Where ID = '{id}'";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<DeliveryOrder>(table)[0];
		}


	}
}
