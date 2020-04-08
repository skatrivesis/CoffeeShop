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
        SqlConnection connection;

        public ProductController(IConfiguration config)
        {
            ConfigRoot = config;
            connection = new SqlConnection(ConfigRoot.GetConnectionString("coffeeShopDB")); 
        }
        public IActionResult Index()
        {
            string queryString = "Select * from products order by category";

            var Products = connection.Query<Product>(queryString);

            ViewData["Products"] = Products;

            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}