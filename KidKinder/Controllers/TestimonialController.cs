using KidKinder.Context;
using KidKinder.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class TestimonialController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult TestimonialList()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateTestimonial() 
        { 
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value = context.Testimonials.Find(testimonial.TestimonialId);
            value.ImageUrl = testimonial.ImageUrl;
            value.NameSurname = testimonial.NameSurname;
            value.Title = testimonial.Title;
            value.Comment = testimonial.Comment;
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}