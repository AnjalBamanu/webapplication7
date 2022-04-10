using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class seocondroller : Controller
    {
        // GET: naya
        practiceEntities db = new practiceEntities();
        public ActionResult Index()
        {
            List<record> all_data = db.records.ToList();
            return View(all_data);
        }
        public ActionResult Arko()
        {

            return View();
        }
        public ActionResult SaveData(record record)
        {
            db.records.Add(record);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       

        public ActionResult Edit(int id)
        {
            record old_data = db.records.Find(id);
            return View(old_data);
          
            
        }
        public ActionResult UpdateData(record record)

        {
            
            db.Entry(record).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}