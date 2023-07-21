using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        public ActionResult Index()
        {
            var degerler = db.tbl_about.ToList();
            return View(degerler);
        }

        public ActionResult PersonList()
        {
            return View();
        }
        public ActionResult DepertmentList()
        {
            return View();
        }
    }
}