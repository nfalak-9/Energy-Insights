using Energy_Insights.Models;
using Microsoft.AspNetCore.Mvc;

namespace Energy_Insights.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            var articles = new List<Articles>
            {
                new Articles { Title = "The Future of Solar Energy", Content = "As we step into 2024, the solar energy landscape is poised for unprecedented growth and innovation...", Link = "https://www.nexamp.com/blog/the-future-of-solar-energy-trends-and-predictions-2024" },
                // Add more articles as needed
            };
            ViewBag.LogoPath = "~/img/logo.png";
            return View(articles);
        }
    }
}
