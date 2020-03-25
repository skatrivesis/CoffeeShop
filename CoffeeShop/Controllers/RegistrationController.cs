using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Register(string fname, string lname, string email, int phone, string password)
        {
            ViewData["name"] = fname + " " + lname;
            ViewData["email"] = email;
            ViewData["phone"] = phone;
            ViewData["password"] = password;

            return View();
        }
    }
}