using Lab.Models;
using Lab.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Controllers
{
    [RoutePrefix("EMP")]
    public class EmployeeController : Controller
    {
        [HttpGet]
        [Route("AllEmployees")]
        public ActionResult Index()
        {
  

            ViewBag.SelectedUserName
                 = ((User)TempData.Peek("SelectedUser")).UserName;
            return View(PermenantData.Employees);
        }


        [HttpGet]
        [Route("GetByID/{id}")]
        public ActionResult Details(int ID)
        {
            var Temp2 = Request.QueryString;
            Employee Temp =
            PermenantData.Employees
                .FirstOrDefault(i => i.ID == ID);

            if (Temp == null)
                return View();


            return View(Temp);
        }


        [HttpGet]
        [Route("~/Create")]
        public ActionResult Create()
        {
            return View();
        }
    }
}