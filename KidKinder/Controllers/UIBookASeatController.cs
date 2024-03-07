using KidKinder.Context;
using KidKinder.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
	[AllowAnonymous]
	public class UIBookASeatController : Controller
    {
		KidKinderContext context = new KidKinderContext();

		[HttpPost]
		public ActionResult CreateBookASeatForUI(BookASeat bookASeat)
		{
			context.BookASeats.Add(bookASeat);
			context.SaveChanges();
			return RedirectToAction("Index", "Default");

		}
	}
}