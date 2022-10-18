using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpChallenges547.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TimePage()
        {
            return View();
        }

        public void OnPost()
        {
            DateTime Message = DateTime.Now;
            Console.WriteLine(Message);
        }

        public DateTime CurrentDateTime { get; set; }
        

        //public void TimeFunction(DateTime time)
        //{
        //    Console.WriteLine(DateTime.Now);
        //    Console.ReadLine();
        //    return;
        //}

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