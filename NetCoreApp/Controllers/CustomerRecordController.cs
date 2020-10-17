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
		
		public string SearchCustomer(string q)
		{
			string query = $"Select Top 10 * From [Customer] Where Name LIKE '{q}%'";
			DataTable table = DataAccess.Fill(query);
			List<Customer> customers = DataTableAdapter.Get<Customer>(table);

			return JsonSerializer.Serialize(customers);
		}

	}
}
