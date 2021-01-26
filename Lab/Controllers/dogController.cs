using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Controllers
{
    public class dogController : Controller
    {
        // GET: dog
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dog()
        {
            return View();
        }
    }
}