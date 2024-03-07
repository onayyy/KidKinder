using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
	[AllowAnonymous]
	public class UITeacherController : Controller
    {
        // GET: UITeacher
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult TeacherHeaderPartial()
        {
            return PartialView();
        }
    }
}