using System.Diagnostics;
using ListWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
