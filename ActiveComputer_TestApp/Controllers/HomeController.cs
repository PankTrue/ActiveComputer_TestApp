using ActiveComputer_TestApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ActiveComputer_TestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult First(int[] arr)
        {
            int result = 0;
            bool isSecond = false;

            foreach (var element in arr)
            {
                if (element % 2 != 0)
                {
                    if (isSecond)
                    {
                        result += element;
                        isSecond = !isSecond;
                    }
                    else
                    {
                        isSecond = !isSecond;
                    }
                }
            }

            ViewBag.Result = Math.Abs(result);

            return View();
        }


        public IActionResult Second()
        {
            return View();
        }


        public IActionResult Third()
        {
            return View();
        }




        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
