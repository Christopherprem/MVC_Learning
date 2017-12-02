using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetLearning.Models; 

namespace DotNetLearning.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Details(int ID)
        {
            //employee emp = new employee();
            //emp.EmpID = 1;
            //emp.Name = "prem";
            //emp.Gender = "Male";
            //emp.City = "Chennai";

          //  EmployeeContext empCtx = new EmployeeContext();
            
            var context = new test2Entities();
            Employee employee = context.Employees.Single(emp => emp.EmpID == ID);
            return View(employee);
        }
    }
}
