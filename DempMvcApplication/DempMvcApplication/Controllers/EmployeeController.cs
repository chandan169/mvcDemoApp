using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DempMvcApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DempMvcApplication.Controllers
{
    [Table("tblEmployee")]
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            return View();
        }        
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            //Employee employee= employeeContext.Employees.Single(e=>e.EmployeeId==id);
            List<Employee> employee=employeeContext.Employees.ToList();
            return View(employee);
        }

    }
}
