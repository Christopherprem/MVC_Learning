using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetLearning.Models;

namespace DotNetLearning.Controllers
{
    public class CountryController : Controller
    {
        //
        // GET: /Country/

        public ActionResult Index()
        {
            testEntities Dbcontext = new testEntities();
            List<Country> cnt = Dbcontext.Countries.ToList();
         
            return View(cnt);
        }

    }
}
