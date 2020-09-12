﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreApp.App_Code;
using NetCoreApp.Models;
using NetCoreApp.Security;

namespace NetCoreApp.Controllers
{
	public class HomeController : Controller, IController
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index(string message)
		{
			ViewBag.message = message;
			if (Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "User", null);
			else
				return View();
		}

		public IActionResult Login(string username, string password)
		{
			//var cookie = HttpContext.Request.Cookies["_"];
			password = MD5.Encrypt(password);
			string query = $"Select * from [User] Where [Username] = '{username}' And [Password] = '{password}'";
			DataTable table = DataAccess.Fill(query);
			List<User> users = DataTableAdapter.Get<User>(table);
			User user = new User();
			if (users.Count > 0)
				user = users[0];
			Credential.CreateSession(HttpContext, user);
			if (user != null)
				return RedirectToAction("Privacy");
			else
				return Index("Usuario o contraseña incorrecto.");
		}

		public IActionResult Privacy()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);
			else
				return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public void Credentials()
		{
			throw new NotImplementedException();
		}
	}
}
