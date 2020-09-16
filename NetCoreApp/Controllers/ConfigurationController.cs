using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;

namespace NetCoreApp.Controllers
{
	public class ConfigurationController : Microsoft.AspNetCore.Mvc.Controller
	{

		/***
		 * 
		 */
		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index","Home",null);
		
			ViewBag.Data = Data.GetDatas();
			return View();
		}

		public IActionResult AddData(string Name, string Description)
		{
			Data.InsertData(Name, Description);
			return RedirectToAction("Index", "Configuration", null);
		}

		public IActionResult EditData(string ID, string Name, string Description)
		{
			Data.UpdateData(ID, Name, Description);
			return RedirectToAction("Index", "Configuration", null);
		}

		public IActionResult DeleteData(string ID)
		{
			//Data.DeleteData(ID);
			return RedirectToAction("Index", "Configuration", null);
		}


		/***
		 * 
		 */
		public IActionResult Privileges()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.Privilege = Privilege.GetPrivileges();
			return View();
		}

		public IActionResult AddPrivilege(string name)
		{
			Privilege.InsertPrivilege(name);
			return RedirectToAction("Privileges", "Configuration", null);
		}

		public IActionResult EditPrivilege(string id, string name)
		{
			Privilege.UpdatePrivilege(id, name);
			return RedirectToAction("Privileges", "Configuration", null);
		}

		public IActionResult DeletePrivilege(string id)
		{
			Privilege.DeletePrivilege(id);
			return RedirectToAction("Privileges", "Configuration", null);
		}

	}
}
