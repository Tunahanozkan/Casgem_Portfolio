using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Casgem_Portfolio.Controllers
{
    public class ContactController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();

        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tbl_message p)
        {
            db.tbl_message.Add(p);
            db.SaveChanges();
            return RedirectToAction("HeaderPartial", "Portfolio");
        }
    }
}