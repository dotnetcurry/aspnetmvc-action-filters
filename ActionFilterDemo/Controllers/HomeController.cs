using ActionFilterDemo.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace ActionFilterDemo.Controllers
{
    public class HomeController : Controller
    {
        [ActionSpeedProfiler]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            
            // Uncomment below to see the 1 second+ 
            // delay in action
            //Thread.Sleep(1000);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
