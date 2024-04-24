using Microsoft.AspNetCore.Mvc;

namespace Energy_Insights.Controllers
{
    public class TotalEnergyProduction : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
