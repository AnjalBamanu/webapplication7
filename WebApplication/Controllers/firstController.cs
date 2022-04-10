using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class firstController : Controller
    {
        // GET: first
        public ActionResult Create()
        {
            List<record> all_data = db.record.ToList();
            return View();

        }
        public ActionResult Add()
        {
            
            return View();

        }
        public ActionResult Edit()
        {
            
            return View();

        }
        public ActionResult Delete()
        {
            
            return View();

        }
    }
}