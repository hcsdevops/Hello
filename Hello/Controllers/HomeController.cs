using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hello.Models;

namespace Hello.Controllers
{
    public class HomeController : Controller
    {
        private GreetingViewModel _model;
        public HomeController()
        {
            _model = new GreetingViewModel();
        }
        public IActionResult Index()
        {

            return View("Index",_model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
