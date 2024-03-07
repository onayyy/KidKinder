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
	public class UIContactController : Controller
    {
		KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
            return View();
        }

		public PartialViewResult ContactHeaderPartial()
		{
			return PartialView();
		}

		public PartialViewResult ContactAddressPartial()
		{
			ViewBag.description = context.Communications.Select(x => x.Description).FirstOrDefault();
			ViewBag.phone = context.Communications.Select(x => x.Phone).FirstOrDefault();
			ViewBag.address = context.Communications.Select(x => x.Address).FirstOrDefault();
			ViewBag.email = context.Communications.Select(x => x.Email).FirstOrDefault();
			return PartialView();
		}

		[HttpPost]
		public ActionResult CreateMessage(Contact contact)
		{
			contact.SendDate = DateTime.Now;
			contact.IsRead = false;
			context.Contacts.Add(contact);
			context.SaveChanges();
			return RedirectToAction("Index", "Default");
		}

	}
}