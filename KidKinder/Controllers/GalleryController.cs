using KidKinder.Context;
using KidKinder.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class GalleryController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
            var value = context.Galleries.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateImage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateImage(Gallery gallery)
        {
            context.Galleries.Add(gallery);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteImage(int id)
        {
            var value = context.Galleries.Find(id);
            context.Galleries.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateImage(int id)
        {
            var value = context.Galleries.Find(id);
            return View(value);
        }

		[HttpPost]
		public ActionResult UpdateImage(Gallery gallery)
		{
			var value = context.Galleries.Find(gallery.GalleryId);
            value.ImageUrl = gallery.ImageUrl;
            value.Status = gallery.Status;
            context.SaveChanges();
            return RedirectToAction("Index");
		}

        [HttpGet]
        public ActionResult StatusPassiveImage(int id)
        {
            var value = context.Galleries.Find(id);
            value.Status = false; 
            context.SaveChanges();
            return RedirectToAction("Index");
        }

		[HttpGet]
		public ActionResult StatusActiveImage(int id)
		{
			var value = context.Galleries.Find(id);
			value.Status = true;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}