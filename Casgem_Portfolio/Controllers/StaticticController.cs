using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class StaticticController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        // GET: Statictic
        public ActionResult Index()
        {
            ViewBag.employeeCount = db.Tbl_Employee.Count();
            var salary = db.Tbl_Employee.Max(x => x.EmployeeSalary);
            ViewBag.maxsalaryemployee= db.Tbl_Employee.Where(x=>x.EmployeeSalary==salary).Select(y=>y.EmployeeName +" "+ y.EmployeeSurname).FirstOrDefault();

            ViewBag.totalCityCount = db.Tbl_Employee.Select(x => x.EmployeeCity).Distinct().Count();

            ViewBag.avgEmployeeSalary =db.Tbl_Employee.Average(x=>x.EmployeeSalary);

            ViewBag.CountSoftwareDepartment = db.Tbl_Employee.Where(x=>x.EmployeeDepartment == db.TblDepartment.Where(z=>z.DepartmentName == "Yazılım").Select(y=>y.DepartmentID).FirstOrDefault()).Count();

            ViewBag.cityAnkaraOrAdanaSumSalary = db.Tbl_Employee.Where(x => x.EmployeeCity == "Ankara" || x.EmployeeCity == "Adana").Sum(y => y.EmployeeSalary);

            ViewBag.sumSalaryFromSoftwareDepartment = db.Tbl_Employee.Where(x => x.EmployeeCity == "Ankara" && x.EmployeeDepartment == db.TblDepartment.Where(z => z.DepartmentName == "Yazılım").Select(y => y.DepartmentID).FirstOrDefault()).Sum(y => y.EmployeeSalary);

            return View();
        }
    }
}