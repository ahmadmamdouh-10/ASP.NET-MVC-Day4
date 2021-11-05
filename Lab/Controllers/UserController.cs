using Lab.Models;
using Lab.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {

            if (user == null)
                return View();

            User SelectedUser =
            InMemoryUserStorage.Users.FirstOrDefault(i => i.UserName
                 == user.UserName && i.Password == user.Password);

            if (SelectedUser == null)
                return View();


            TempData["SelectedUser"] = SelectedUser;


            return Redirect("/EMP/AllEmployees");

        }
    }
}