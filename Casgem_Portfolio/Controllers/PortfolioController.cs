using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        CasgemPortfolioEntities1 db =new CasgemPortfolioEntities1();
        // GET: Portfolio
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            var textArray = db.tbl_skills.Select(x => x.Skill).ToArray();

            ViewBag.skillArray = textArray;
            return PartialView();
        }
        public PartialViewResult FooterScript()
        {

            var values = db.tbl_socialmedya.ToList();
            return PartialView(values);
        }
        public PartialViewResult TestMonialPartial()
        {
            var values = db.tbl_referance.ToList();
            return PartialView(values);
        }
        public PartialViewResult FeaturePartial()
        {
            ViewBag.featureTitle = db.tbl_feature.Select(x => x.FeatureTitle).FirstOrDefault();
            ViewBag.featureDescription = db.tbl_feature.Select(x => x.FeatureDescription).FirstOrDefault();
            ViewBag.featureImage = db.tbl_feature.Select(x => x.FeatureImage).FirstOrDefault();



            return PartialView();

        }

        public PartialViewResult MyResume()
        {
            var values = db.tbl_resume.ToList();
            return PartialView(values);
        }

        public PartialViewResult StatisticPartial()
        {
            ViewBag.totalService = db.tbl_service.Count();
            ViewBag.totalMessage = db.tbl_message.Count();
            ViewBag.totalThanksMessage = db.tbl_message.Where(x => x.MessageSubject == "Teşekkürler").Count();
            ViewBag.happyCustomer = 12;
            return PartialView();
        }
        public PartialViewResult WhoamiPartial()
        {

            var values = db.tbl_about.ToList();
            return PartialView(values);
        }
        public PartialViewResult VideoPartial()
        {
            var values = db.tbl_video.ToList();
            return PartialView(values);
        }
        public PartialViewResult FreelancePartial()
        {
            return PartialView();
        }
        public PartialViewResult ServicesPartial()
        {

            var values = db.tbl_service.ToList();
            return PartialView(values);
        }
    }
}