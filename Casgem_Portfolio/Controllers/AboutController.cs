using Casgem_Portfolio.Models.Entities;
using Casgem_Portfolio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class AboutController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        GenericRepository<tbl_about> repository = new GenericRepository<tbl_about>();
        // GET: About
        [HttpGet]
        public ActionResult Index()
        {
            var x = repository.List();
            return View(x);
        }

        [HttpPost]
        public ActionResult Index(tbl_about p)
        {
            var t = repository.Find(x => x.AboutID == 1);
            t.Name = p.Name;
            t.Surname = p.Surname;
            t.Address = p.Address;
            t.Mail = p.Mail;
            t.PhoneNumber = p.PhoneNumber;
            t.Des = p.Des;

            t.ImageUrl = p.ImageUrl;
            repository.XUpdate(t);
            return RedirectToAction("Index");
        }
        public ActionResult ContactDetails(int id)
        {
            var value = db.tbl_about.Find(id);
            return View(value);
        }
    }
}