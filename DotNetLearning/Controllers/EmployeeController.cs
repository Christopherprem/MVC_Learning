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


        public ActionResult Index( )
        {
            testEntities Dbcontext = new testEntities();
            List<Employee> Emp = Dbcontext.Employees.ToList();
            return View(Emp);
        }


        public ActionResult Details(int ID)
        {

           // var context = new test2Entities();
            testEntities Dbcontext = new testEntities();

            Employee employee = Dbcontext.Employees.Single(emp => emp.EmpID == ID);
            return View(employee);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create()
        {
            return View();
        }

         [HttpPost]
         [ActionName("Add_new")]
        public ActionResult Create_new(Employee employee)
        {

            if (ModelState.IsValid)
            {
                testEntities Dbcontext = new testEntities();

                Dbcontext.Employees.Add(employee);
                Dbcontext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }


         [HttpPost]
         [ActionName("Add")]
         public ActionResult Create_add()
         {
             Employee employee = new Employee();

            // UpdateModel(employee);
             TryUpdateModel(employee);
             if (ModelState.IsValid)
             {
                 testEntities Dbcontext = new testEntities();

                 Dbcontext.Employees.Add(employee);
                 Dbcontext.SaveChanges();
                 return RedirectToAction("Index");
             }

             return View();
         }
    }
}
