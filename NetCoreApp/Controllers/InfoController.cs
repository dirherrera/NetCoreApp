﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InfoController : ControllerBase
	{
		public string Index()
		{
			return "{}";
		}
	}
}
