using KidKinder.Context;
using KidKinder.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class BookASeatController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult BookASeatList()
        {
            var values = context.BookASeats.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateBookASeat()
        {
			List<SelectListItem> values = (from x in context.ClassRooms.ToList()
										   select new SelectListItem
										   {
											   Text = x.Title,
											   Value = x.ClassRoomId.ToString()
										   }).ToList();
			ViewBag.v = values;
			return View();
        }

        [HttpPost]
        public ActionResult CreateBookASeat(BookASeat bookASeat)
        {
            context.BookASeats.Add(bookASeat);
			context.SaveChanges();
			return RedirectToAction("BookASeatList");
        
        }

		public ActionResult DeleteBookASeat(int id)
		{
			var value = context.BookASeats.Find(id);
			context.BookASeats.Remove(value);
			context.SaveChanges();
			return RedirectToAction("BookASeatList");
		}

		[HttpGet]
		public ActionResult UpdateBookASeat(int id)
		{
			List<SelectListItem> values = (from x in context.ClassRooms.ToList()
										   select new SelectListItem
										   {
											   Text = x.Title,
											   Value = x.ClassRoomId.ToString()
										   }).ToList();
			ViewBag.v = values;
			var value = context.BookASeats.Find(id);
			return View(value);
		}

		[HttpPost]
		public ActionResult UpdateBookASeat(BookASeat bookASeat)
		{
			var value = context.BookASeats.Find(bookASeat.BookASeatId);
			value.Name = bookASeat.Name;
			value.Email = bookASeat.Email;
			value.ClassRoomId = bookASeat.ClassRoomId;
			context.SaveChanges();
			return RedirectToAction("BookASeatList");
		}
	}
}