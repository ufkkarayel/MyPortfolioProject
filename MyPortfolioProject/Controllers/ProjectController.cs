using MyPortfolioProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Projects.ToList();
            return View(values);
        }
    }
}