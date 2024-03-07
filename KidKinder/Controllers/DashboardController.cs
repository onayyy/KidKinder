using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entites;

namespace KidKinder.Controllers
{
    public class DashboardController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult DashboardPartial1()
        {
			//Branşı Matematik Olan öğretmen Sayısı
			ViewBag.MatematikCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.Name == "Matematik").Select(y => y.BranchId).FirstOrDefault()).Count();

			ViewBag.AvgPrice = context.ClassRooms.Average(x => x.Price).ToString("0.00");

			ViewBag.TeacherCount = context.Teachers.Count();

			ViewBag.BranchCount = context.Branches.Count();
			return PartialView();
        }

		public PartialViewResult DashboardPartial2()
		{
			ViewBag.ClassRoomCount = context.ClassRooms.Count();

			ViewBag.ContactCount = context.Contacts.Count();

			ViewBag.UnReadMessageCount = context.Contacts.Where(x => x.IsRead ==  false).Count();

			ViewBag.ServiceCount = context.Services.Count();
	
			return PartialView();
		}

		public PartialViewResult DashboardPartial3()
		{
			ViewBag.SubscribeCount = context.MailSubscribes.Count();

			ViewBag.BookASeatCount = context.BookASeats.Count();

			return PartialView();
		}

		public PartialViewResult DashboardPartial4()
		{
			var values = context.Teachers.ToList();
			return PartialView(values);
		}

		public PartialViewResult DashboardPartial5()
		{
			var values = context.Testimonials.ToList();
			return PartialView(values);
		}
	}
}