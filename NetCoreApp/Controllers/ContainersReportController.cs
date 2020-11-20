using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;

namespace NetCoreApp.Controllers
{
	public class ContainersReportController : Microsoft.AspNetCore.Mvc.Controller
	{
		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			return View();
		}

	}
}
