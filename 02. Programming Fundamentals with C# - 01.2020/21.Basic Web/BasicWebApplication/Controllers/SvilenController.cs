using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BasicWebApplication.Controllers
{
    public class SvilenController : Controller
    {
        public IActionResult Hello(int id = 10)
        {
            int number = 0;
            List<string> result = new List<string>();

            for (int i = 0; i < id; i++)
            {
                number++;
                result.Add(number.ToString());
            }

            ViewBag.Num = string.Join(" ", result);
            return View();
        }
    }
}