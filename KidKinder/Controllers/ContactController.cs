using KidKinder.Context;
using KidKinder.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class ContactController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }


        public ActionResult DeleteContact(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


		[HttpGet]
		public ActionResult OpenMessageContact(int id)
		{
			var values = context.Contacts.Find(id);
			values.IsRead = true;
			context.SaveChanges();
			return View(values);
		}


	}
}