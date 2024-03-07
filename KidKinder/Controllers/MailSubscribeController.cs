using KidKinder.Context;
using KidKinder.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class MailSubscribeController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
            var value = context.MailSubscribes.ToList();
            return View(value);
        }

   

        [HttpGet]
		public ActionResult CreateMailSubscribe()
		{
			return View();
		}

		[HttpPost]
		public ActionResult CreateMailSubscribe(MailSubscribe mailSubscribe)
		{
			context.MailSubscribes.Add(mailSubscribe);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

        public ActionResult DeleteMailSubscribe(int id)
        {
            var value = context.MailSubscribes.Find(id);
            context.MailSubscribes.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateMailSubscribe(int id)
        {
            var value = context.MailSubscribes.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateMailSubscribe(MailSubscribe mailSubscribe)
        {
            var value = context.MailSubscribes.Find(mailSubscribe.MailSubscribeId);
            value.NameSurname = mailSubscribe.NameSurname;
            value.Email = mailSubscribe.Email;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}