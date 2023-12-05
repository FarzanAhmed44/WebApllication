using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            return View("datass");
        }
    }
}
