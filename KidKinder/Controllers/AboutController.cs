using KidKinder.Context;
using KidKinder.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class AboutController : Controller
    {
		KidKinderContext context = new KidKinderContext();

		public ActionResult AboutList()
		{
			var values = context.Abouts.ToList();
			return View(values);
		}

		[HttpGet]
		public ActionResult CreateAbout()
		{
			return View();
		}

		[HttpPost]
		public ActionResult CreateAbout(About about)
		{
			context.Abouts.Add(about);
			context.SaveChanges();
			return RedirectToAction("AboutList");
		}

		public ActionResult DeleteAbout(int id)
		{
			var value = context.Abouts.Find(id);
			context.Abouts.Remove(value);
			context.SaveChanges();
			return RedirectToAction("AboutList");
		}

		[HttpGet]
		public ActionResult UpdateAbout(int id)
		{
			var value = context.Abouts.Find(id);
			return View(value);
		}

		[HttpPost]
		public ActionResult UpdateAbout(About about)
		{
			var value = context.Abouts.Find(about.AboutId);
			value.BigImageUrl = about.BigImageUrl;
			value.Header = about.Header;
			value.Title = about.Title;
			value.Description = about.Description;
			value.SmallImageUrl = about.SmallImageUrl;
			context.SaveChanges();
			return RedirectToAction("AboutList");
		}
	}
}