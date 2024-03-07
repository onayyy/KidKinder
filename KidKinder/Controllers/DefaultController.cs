using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entites;
using KidKinder.Context;

namespace KidKinder.Controllers
{
	[AllowAnonymous]
	public class DefaultController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar() 
        { 
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
			var values = context.Features.ToList();
            return PartialView(values);
        }

		public PartialViewResult PartialService()
		{
			var values = context.Services.ToList();
			return PartialView(values);
		}

		public PartialViewResult PartialAbout()
		{
			var values = context.Abouts.ToList();
			return PartialView(values);
		}

		public PartialViewResult PartialAboutList()
		{
			var values = context.AboutLists.ToList();
			return PartialView(values);
		}

		public PartialViewResult PartialClassRooms()
		{
			var values = context.ClassRooms.OrderByDescending(item => item.ClassRoomId).Take(3).ToList();
			return PartialView(values);
		}

        public PartialViewResult PartialBookASeat()
        {
            return PartialView();
        }

		public PartialViewResult PartialBookASeatProcess()
		{
			List<SelectListItem> values = (from x in context.ClassRooms.ToList()
										   select new SelectListItem
										   {
											   Text = x.Title,
											   Value = x.ClassRoomId.ToString()
										   }).ToList();
			ViewBag.v = values;
			return PartialView();
		}

		public PartialViewResult PartialTeacher()
		{
			var values = context.Teachers.ToList();
			return PartialView(values);
		}

		public PartialViewResult PartialTestimonial()
		{
			var values = context.Testimonials.ToList();
			return PartialView(values);
		}

		public PartialViewResult PartialFooter()
		{
			ViewBag.description = context.Communications.Select(x => x.Description).FirstOrDefault();
			ViewBag.phone = context.Communications.Select(x => x.Phone).FirstOrDefault();
			ViewBag.address = context.Communications.Select(x => x.Address).FirstOrDefault();
			ViewBag.email = context.Communications.Select(x => x.Email).FirstOrDefault();
			return PartialView();
		}

		public PartialViewResult PartialScript()
		{
			return PartialView();
		}
	}
}