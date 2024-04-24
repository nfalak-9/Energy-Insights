using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Energy_Insights.Models;

namespace Energy_Insights.Controllers
{
    public class TotalEnergyProductionController : Controller
    {
        public IActionResult Index()
        {
            var energyData = new List<TotalEnergyProductionModel>
            {
                new TotalEnergyProductionModel { Country = "USA", TotalEnergy = 1350, RenewableEnergy = 330, NonrenewableEnergy = 1020 },
                new TotalEnergyProductionModel { Country = "India", TotalEnergy = 730, RenewableEnergy = 165, NonrenewableEnergy = 565 },
                new TotalEnergyProductionModel { Country = "China", TotalEnergy = 2060, RenewableEnergy = 800, NonrenewableEnergy = 1260 },
                new TotalEnergyProductionModel { Country = "Germany", TotalEnergy = 398, RenewableEnergy = 160, NonrenewableEnergy = 238 },
                new TotalEnergyProductionModel { Country = "Russia", TotalEnergy = 759, RenewableEnergy = 39, NonrenewableEnergy = 720 }
            };

            return View("TotalEnergyProduction",energyData);
        }
    }
}
