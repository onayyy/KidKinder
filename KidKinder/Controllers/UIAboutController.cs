﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
	[AllowAnonymous]
	public class UIAboutController : Controller
    {
		public ActionResult Index()
		{
			return View();
		}

		public PartialViewResult AboutHeaderPartial()
		{
			return PartialView();
		}
	}
}