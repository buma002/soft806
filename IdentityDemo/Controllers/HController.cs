using IdentityDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IdentityDemo.Controllers
{
    public class HController : Controller
    {
        private readonly ILogger<HController> _logger;

        public HController(ILogger<HController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult eRrr()
        {
            return View(new Errors { ReQid = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}