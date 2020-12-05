using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetCoreApp.API
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{

		[HttpGet("Get")]
		public ActionResult<string> Get()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return "";

			List<Customer> customers = NetCoreApp.Models.User.GetCustomerNotAssign();

			DataTablesJson json = new DataTablesJson();
			json.data = customers.ToArray();
			string result = System.Text.Json.JsonSerializer.Serialize(json);
			return result;
		}

	}
}
