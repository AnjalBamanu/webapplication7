using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SecondController : Controller
    {
        employeeEntities db = new employeeEntities();
        // GET: Second
        public ActionResult Salary()
        {

            return View();
        }
        public ActionResult SalaryTable()
        {

            return View();
        }
        public ActionResult Save_salarydata(emp_salary obj)
        {
            db.emp_salary.Add(obj);
            db.SaveChanges();
            return RedirectToAction("SalaryTable");
        }

    }
}