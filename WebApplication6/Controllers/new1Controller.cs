using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class new1Controller : Controller

    {
        // GET: new1
        practiceEntities db = practiceEntities();

        private static practiceEntities practiceEntities()
        {
            throw new NotImplementedException();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}