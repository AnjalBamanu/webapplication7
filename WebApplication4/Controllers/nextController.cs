using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class nextController : Controller
    {
        try1Entities db = new try1Entities();
        // GET: next
        public ActionResult Index1()
        {
            List<anjal1> all_data = db.anjal1.ToList();
            return View(all_data);
        }
    }
}
