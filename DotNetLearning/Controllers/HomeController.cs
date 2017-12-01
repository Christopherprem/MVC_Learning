using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetLearning.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.initialData = "The initial data";
            return View();
        }

        //to check query string
        public ActionResult queryString_Test(string ID,string Custom )
        {
            ViewBag.data1 = ID;
            ViewBag.data2 = Custom;
            
            return View();
        }


        public ActionResult Contries()
        {

            ViewBag.ContriesList  =  new List<string>() {
                "India",
                   "UK",
                   "China"
            };

            return View();
        }

    }
}
