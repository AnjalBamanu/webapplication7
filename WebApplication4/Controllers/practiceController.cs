using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class practiceController : Controller
    {
        // GET: practice
        try1Entities db = new try1Entities();

       
     
            
        public ActionResult Index()
        {
            List<anjal> all_data = db.anjals.ToList();
            return View(all_data);
        }
    }
}