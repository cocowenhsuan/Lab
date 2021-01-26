using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Controllers
{
    public class CatController : Controller
    {
        // GET: Cat
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Intro()
        {
            var i = 0;
            return View();
        }
    }
}