using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FirstController : Controller
    {
        // GET: First

        employeeEntities db = new employeeEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MainTable()
        {
            List<emp_table> all_data = db.emp_table.ToList(); 
            return View(all_data);
        }
        public ActionResult Add_empdata()
        {
            return View();
        }

        public ActionResult Save_empdata(emp_table obj)
        {
            db.emp_table.Add(obj);
            db.SaveChanges();
            return RedirectToAction("MainTable");
        }
        public ActionResult Edit_empdata(int e_id)
        {
            emp_table obj1=db.emp_table.Find(e_id);   
            return View(obj1);
        }
        public ActionResult Update_employeedata(emp_table obj)
        {
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("MainTable");
        }
        public ActionResult Delete_empdata(int e_id)
        {
            emp_table emp_Table = db.emp_table.Find(e_id);
            db.emp_table.Remove(emp_Table);
            db.SaveChanges();
            return RedirectToAction("MainTable");
        }



    }

}