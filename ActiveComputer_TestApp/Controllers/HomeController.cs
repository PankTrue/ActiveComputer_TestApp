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


        public IActionResult Second(LinkedList<int> arr1, LinkedList<int> arr2)
        {
            var result = new LinkedList<int>();

            var iterator1 = arr1.GetEnumerator();
            var iterator2 = arr2.GetEnumerator();

            while (iterator1.MoveNext() && iterator2.MoveNext())
            {
                result.AddLast(iterator1.Current + iterator2.Current);
            } 

            ViewBag.Result = result;

            return View();
        }


        public IActionResult Third(string str)
        {
            bool isPalindrom = true;

            for (var i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    isPalindrom = false;
                    break;
                }
            }

            ViewBag.Str = str;
            ViewBag.isPalindrom = isPalindrom;

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
