using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace Energy_Insights.Controllers
{
    public class NonRenewableResourcesController : Controller
    {
        public IActionResult Index()
        {
            var energyDataList = new List<NonRenewableResourcesModel>
        {
            new NonRenewableResourcesModel
            {
                Country = "USA",
                EnergyTypes = new Dictionary<string, string>
                {
                    { "Coal", "500 GW" },
                    { "NaturalGas", "350 GW" },
                    { "Nuclear", "100 GW" },
                    { "Oil", "70 GW" }
                }
            },
            new NonRenewableResourcesModel
            {
                Country = "India",
                EnergyTypes = new Dictionary<string, string>
                {
                    { "Coal", "450 GW" },
                    { "NaturalGas", "50 GW" },
                    { "Nuclear", "40 GW" },
                    { "Oil", "25 GW" }
                }
            },
            new NonRenewableResourcesModel
            {
                Country = "China",
                EnergyTypes = new Dictionary<string, string>
                {
                    { "Coal", "900 GW" },
                    { "NaturalGas", "200 GW" },
                    { "Nuclear", "60 GW" },
                    { "Oil", "100 GW" }
                }
            },
            new NonRenewableResourcesModel
            {
                Country = "Russia",
                EnergyTypes = new Dictionary<string, string>
                {
                    { "Coal", "170 GW" },
                    { "NaturalGas", "300 GW" },
                    { "Nuclear", "50 GW" },
                    { "Oil", "200 GW" }
                }
            },
            new NonRenewableResourcesModel
            {
                Country = "Germany",
                EnergyTypes = new Dictionary<string, string>
                {
                    { "Coal", "100 GW" },
                    { "NaturalGas", "80 GW" },
                    { "Nuclear", "8 GW" },
                    { "Oil", "50 GW" }
                }
            }
        };

           
            return View("NonRenewableResources", energyDataList);
        }
    }

    public class NonRenewableResourcesModel
    {
        public string Country { get; set; }
        public Dictionary<string, string> EnergyTypes { get; set; }
    }
}