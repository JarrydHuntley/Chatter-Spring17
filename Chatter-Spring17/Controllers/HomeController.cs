using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chatter_Spring17.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            double totalNumberCalculated = 0;
            ViewBag.Message = "This is where you can find more info! :)";
            do
            {
                totalNumberCalculated += 2.7;
            }
            while (totalNumberCalculated< 10.0);

            ViewBag.TotalNumberCalculated = totalNumberCalculated;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}