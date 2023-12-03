using MyPortfolioProject.DAL.Context;
using MyPortfolioProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Testimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial testimonial)
        {
            db.Testimonials.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.Testimonials.Find(id);
            db.Testimonials.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.Testimonials.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value = db.Testimonials.Find(testimonial.TestimonialID);
            value.Name = testimonial.Name;
            value.ImageUrl = testimonial.ImageUrl;
            value.Title = testimonial.Title;
            value.Comment = testimonial.Comment;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}