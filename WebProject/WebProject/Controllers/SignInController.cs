﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class SignInController : Controller
    {
        // GET: SighIn
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginData loginData)
        {
            //Рандомный емаил и пароль
            string validEmail = "user@example.com";
            string validPassword = "password";


            if (loginData.Email == validEmail && loginData.Password == validPassword)
            {
                HomeController.IsAuthorized = true;
                HomeController.IsAdmin = true;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Если логин и/или пароль неверные, возвращаем обратно к форме входаs
                ViewBag.ErrorMessage = "Invalid email or password";
                return View();
            }
        }

        public ActionResult LogOut()
        {
            HomeController.IsAuthorized = false;
            HomeController.IsAdmin = false;
            return RedirectToAction("Index", "Home");
        }

    }
}