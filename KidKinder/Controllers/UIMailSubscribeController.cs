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

	public class UIMailSubscribeController : Controller
    {
		KidKinderContext context = new KidKinderContext();

		[HttpPost]
		public ActionResult CreateMailSubscribeForUI(MailSubscribe mailSubscribe)
		{
			context.MailSubscribes.Add(mailSubscribe);
			context.SaveChanges();
			return RedirectToAction("Index", "Default");
		}
	}
}