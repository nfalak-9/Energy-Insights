using Energy_Insights.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Energy_Insights.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new HomeModel
            {
                Title = "Global Energy Insights",
                WelcomeMessage = "Explore insights into global energy production, both renewable and nonrenewable sources. Understand the dynamics shaping our energy future.",
                
            };
            ViewBag.LogoPath = "~/img/logo.png";
            return View(model);
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
