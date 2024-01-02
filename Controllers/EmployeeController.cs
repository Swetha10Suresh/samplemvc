using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee employee = new Employee();
            employee.EmployeeId = 1;
            employee.Name = "John";
            employee.Gender = "Male";
            employee.city = "London";

            return View(employee);
        }
    }
}