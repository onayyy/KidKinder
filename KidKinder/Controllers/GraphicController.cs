using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class GraphicController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
            ViewBag.MatematikCount = context.Teachers.Where(x => x.Branch.Name == "Matematik").Count();
            ViewBag.ResimCizimCount = context.Teachers.Where(x => x.Branch.Name == "Resim Çizim").Count();
            ViewBag.RobotikKodlamaCount = context.Teachers.Where(x => x.Branch.Name == "Robotik Kodlama").Count();
            ViewBag.ingilizceCount = context.Teachers.Where(x => x.Branch.Name == "İngilizce").Count();
            ViewBag.ispanyolcaCount = context.Teachers.Where(x => x.Branch.Name == "İspanyolca").Count();

            return View();
        }
    }
}