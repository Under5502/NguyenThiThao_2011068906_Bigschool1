﻿using Bigschool1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bigschool1.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext _dbContext;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
            .Include(c => c.Lecturer)
            .Include(c => c.Category)
            .Where(c => c.DateTime > DateTime.Now);

            return View(upcommingCourses);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}