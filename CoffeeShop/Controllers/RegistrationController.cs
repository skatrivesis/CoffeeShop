using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserRegistration userRegistration)
        {
            if (ModelState.IsValid)
            {
                return View(userRegistration);
            }
            else
            {
                ViewData["errorMsg"] = "Looks like the form was filled out incorrectly. Please try again.";
                return View("Index", userRegistration);
            }
        }

        //[HttpPost]
        //public IActionResult Register(string fname, string lname, string email, int phone, string password)
        //{
        //    ViewData["name"] = fname + " " + lname;
        //    ViewData["email"] = email;
        //    ViewData["phone"] = phone;
        //    ViewData["password"] = password;
        //    ViewData["preferedCoffee"] = pCoffee;

        //    return View();
        //}
    }
}