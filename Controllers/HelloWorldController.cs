using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public string Tix()
        {
            return "Hiirekülas käib rahulik melu";
        }
        public IActionResult Welcome(string name, int numTime = 1, int id = 1)
        {
            ViewData["Message"] = $"Hello {name}";
            ViewData["NumTimes"] = numTime;
            return View();
        }
        
    }
}
