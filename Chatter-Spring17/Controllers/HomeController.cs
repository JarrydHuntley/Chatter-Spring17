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
            ViewBag.Message = "This is where you can learn about this company";
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += i;
            }

            double totalNumberCalculated = 0;
            do
            {
                totalNumberCalculated += 2.7;
            }
            while (totalNumberCalculated < 10.0);

            ViewBag.TotalNumberCalculated = totalNumberCalculated;

            ViewBag.TotalNumber = total;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}