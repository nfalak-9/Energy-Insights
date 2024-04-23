using Energy_Insights.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Energy_Insights.Controllers
{
    public class RenewableResourcesController : Controller
    {
        public IActionResult Index()
        {
            var energyDataList = new List<RenewableResourcesModel>
            {
                new RenewableResourcesModel
                {
                    Country = "USA",
                    EnergyTypes = new Dictionary<string, string>
                    {
                        { "Solar", "100 GW" },
                        { "Wind", "150 GW" },
                        { "Hydro", "80 GW" }
                    }
                },
                new RenewableResourcesModel
                {
                    Country = "India",
                    EnergyTypes = new Dictionary<string, string>
                    {
                        { "Solar", "50 GW" },
                        { "Wind", "60 GW" },
                        { "Hydro", "45 GW" },
                        { "Biomass", "10 GW" }
                    }
                },
                new RenewableResourcesModel
                {
                    Country = "China",
                    EnergyTypes = new Dictionary<string, string>
                    {
                        { "Solar", "200 GW" },
                        { "Wind", "300 GW" },
                        { "Hydro", "250 GW" },
                        { "Biomass", "50 GW" }
                    }
                },
                new RenewableResourcesModel
                {
                    Country = "Russia",
                    EnergyTypes = new Dictionary<string, string>
                    {
                        { "Hydro", "30 GW" },
                        { "Wind", "5 GW" },
                        { "Biomass", "4 GW" }
                    }
                },
                new RenewableResourcesModel
                {
                    Country = "Germany",
                    EnergyTypes = new Dictionary<string, string>
                    {
                        { "Solar", "60 GW" },
                        { "Wind", "70 GW" },
                        { "Biomass", "20 GW" },
                        { "Hydro", "10 GW" }
                    }
                }
            };

            ViewBag.LogoPath = "~/img/renew.jpeg"; 
            return View("RenewableResources", energyDataList);
        }
    }
}

