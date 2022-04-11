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

        public ActionResult Add_Salary()
        {
            var emplist = db.emp_table.ToList();
            ViewBag.employeList = new SelectList(emplist, "e_id", "e_name");
            return View();
        }
        public ActionResult SalaryTable()
        {
            List<emp_salary> all_data = db.emp_salary.ToList();
            return View(all_data);

        }
        public ActionResult Save_salarydata(emp_salary obj)
        {
            db.emp_salary.Add(obj);
            db.SaveChanges();
            return RedirectToAction("SalaryTable");
        }
        public ActionResult Edit_Salary(int s_id)
        {
            emp_salary obj1 = db.emp_salary.Find(s_id);
            return View(obj1);

        }
        public ActionResult Update_salarydata(emp_salary obj)
        {
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("SalaryTable");
        }
    }
}