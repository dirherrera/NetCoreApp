using NetCoreApp.Models;
using NetCoreApp.Security;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.Json;

namespace NetCoreApp.Controllers
{
	public class CustomerRecordController : Microsoft.AspNetCore.Mvc.Controller
	{

		public Microsoft.AspNetCore.Mvc.IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);



			return View();
		}
		
		public string SearchCustomer(string query)
		{
			string squery = $"Select Top 10 * From [Customer] Where Name LIKE '%{query}%'";
			DataTable table = DataAccess.Fill(squery);
			List<Customer> customers = DataTableAdapter.Get<Customer>(table);

			return JsonSerializer.Serialize(customers);
		}

	}
}
