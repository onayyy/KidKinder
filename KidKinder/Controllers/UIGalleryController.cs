using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
	[AllowAnonymous]
	public class UIGalleryController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        
        public ActionResult Index()
        {
            var value = context.Galleries.ToList();
            return View(value);
        }

		public PartialViewResult GalleryHeaderPartial()
		{
			return PartialView();
		}
	}
}