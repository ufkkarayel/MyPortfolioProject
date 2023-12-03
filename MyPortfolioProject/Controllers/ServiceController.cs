using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        Context db = new Context();
        
        public ActionResult Index()
        {
            var values = db.Services.ToList();
            return View(values);
        }
        public ActionResult AddService()
        {
            return View();
        }
    }
}