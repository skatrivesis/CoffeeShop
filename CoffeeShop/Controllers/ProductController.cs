using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using CoffeeShop.Models;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        IConfiguration ConfigRoot;
        DAL dal;

        public ProductController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("coffeeShopDB")); 
        }
        public IActionResult Index()
        {
            ViewData["Products"] = dal.GetProductsAll();

            return View("ProductIndex");
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}