using Energy_Insights.Data;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;


namespace Energy_Insights.Models
{


    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Data.Energy_InsightsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Energy_InsightsContext>>()))
            {
                // Look for any movies.

                if (context.EnergyGenerationModel.Any())
                {
                    return; // Database has been seeded
                }


                // Seed countries
                List<CountryModel> cntryList = new List<CountryModel> {
                new CountryModel { Name = "USA" },
                    new CountryModel { Name = "India" },
                    new CountryModel { Name = "China" },
                    new CountryModel { Name = "Russia" },
                    new CountryModel { Name = "Germany" }
                    };
                Dictionary<String, CountryModel> countries = new Dictionary<string, CountryModel>();
                {
                    foreach (CountryModel country in cntryList)
                    {

                        countries.Add(country.Name, country);

                    };




                    // Seed energy types and energy generations
                    var energyTypes = new List<EnergyTypeModel>
        {
            new EnergyTypeModel { Category = "Nonrenewable", Name = "Coal" },
            new EnergyTypeModel { Category = "Nonrenewable", Name = "NaturalGas" },
            new EnergyTypeModel { Category = "Nonrenewable", Name = "Nuclear" },
            new EnergyTypeModel { Category = "Nonrenewable", Name = "Oil" },
            new EnergyTypeModel { Category = "Renewable", Name = "Solar" },
            new EnergyTypeModel { Category = "Renewable", Name = "Wind" },
            new EnergyTypeModel { Category = "Renewable", Name = "Hydro" },
            new EnergyTypeModel { Category = "Renewable", Name = "Biomass" }
        };
                    Dictionary<String, EnergyTypeModel> energyData = new Dictionary<String, EnergyTypeModel>();
                    foreach (EnergyTypeModel e in energyTypes)
                    {
                        energyData.Add(e.Name, e);
                    }


                    context.EnergyGenerationModel.AddRange(

                        new EnergyGenerationModel
                        {
                            Country = countries["USA"],
                            EnergyType = energyData["Coal"],
                            Amount = 500
                        },
                         new EnergyGenerationModel
                         {
                             Country = countries["USA"],
                             EnergyType = energyData["Solar"],
                             Amount = 100
                         },
                          new EnergyGenerationModel
                          {
                              Country = countries["USA"],
                              EnergyType = energyData["Wind"],
                              Amount = 150
                          },
                           new EnergyGenerationModel
                           {
                               Country = countries["USA"],
                               EnergyType = energyData["Hydro"],
                               Amount = 80
                           },
                            new EnergyGenerationModel
                            {
                                Country = countries["USA"],
                                EnergyType = energyData["NaturalGas"],
                                Amount = 350
                            },
                             new EnergyGenerationModel
                             {
                                 Country = countries["USA"],
                                 EnergyType = energyData["Nuclear"],
                                 Amount = 100
                             },
                              new EnergyGenerationModel
                              {
                                  Country = countries["USA"],
                                  EnergyType = energyData["Oil"],
                                  Amount = 70
                              },
                               new EnergyGenerationModel
                               {
                                   Country = countries["China"],
                                   EnergyType = energyData["Coal"],
                                   Amount = 900
                               },
                                new EnergyGenerationModel
                                {
                                    Country = countries["China"],
                                    EnergyType = energyData["NaturalGas"],
                                    Amount = 200
                                },
                                 new EnergyGenerationModel
                                 {
                                     Country = countries["China"],
                                     EnergyType = energyData["Nuclear"],
                                     Amount = 60
                                 },
                                  new EnergyGenerationModel
                                  {
                                      Country = countries["China"],
                                      EnergyType = energyData["Oil"],
                                      Amount = 100
                                  },
                                   new EnergyGenerationModel
                                   {
                                       Country = countries["China"],
                                       EnergyType = energyData["Solar"],
                                       Amount = 200
                                   },
                                    new EnergyGenerationModel
                                    {
                                        Country = countries["China"],
                                        EnergyType = energyData["Wind"],
                                        Amount = 300
                                    },
                                     new EnergyGenerationModel
                                     {
                                         Country = countries["China"],
                                         EnergyType = energyData["Hydro"],
                                         Amount = 250
                                     },
                                      new EnergyGenerationModel
                                      {
                                          Country = countries["China"],
                                          EnergyType = energyData["Biomass"],
                                          Amount = 50
                                      },
                                      new EnergyGenerationModel
                                      {
                                          Country = countries["India"],
                                          EnergyType = energyData["Coal"],
                                          Amount = 450
                                      },
                                      new EnergyGenerationModel
                                      {
                                          Country = countries["India"],
                                          EnergyType = energyData["NaturalGas"],
                                          Amount = 50
                                      },
                                       new EnergyGenerationModel
                                       {
                                           Country = countries["India"],
                                           EnergyType = energyData["Nuclear"],
                                           Amount = 40
                                       },
                                        new EnergyGenerationModel
                                        {
                                            Country = countries["India"],
                                            EnergyType = energyData["Oil"],
                                            Amount = 25
                                        },
                                         new EnergyGenerationModel
                                         {
                                             Country = countries["Russia"],
                                             EnergyType = energyData["Coal"],
                                             Amount = 170
                                         },
                                          new EnergyGenerationModel
                                          {
                                              Country = countries["Russia"],
                                              EnergyType = energyData["NaturalGas"],
                                              Amount = 300
                                          },
                                           new EnergyGenerationModel
                                           {
                                               Country = countries["Russia"],
                                               EnergyType = energyData["Nuclear"],
                                               Amount = 50
                                           },
                                            new EnergyGenerationModel
                                            {
                                                Country = countries["Russia"],
                                                EnergyType = energyData["Oil"],
                                                Amount = 200
                                            },
                                             new EnergyGenerationModel
                                             {
                                                 Country = countries["Germany"],

                                                 EnergyType = energyData["Coal"],
                                                 Amount = 100
                                             },
                                              new EnergyGenerationModel
                                              {
                                                  Country = countries["Germany"],
                                                  EnergyType = energyData["NaturalGas"],
                                                  Amount = 80
                                              },
                                               new EnergyGenerationModel
                                               {
                                                   Country = countries["Germany"],
                                                   EnergyType = energyData["Nuclear"],
                                                   Amount = 8
                                               },
                                                new EnergyGenerationModel
                                                {
                                                    Country = countries["Germany"],
                                                    EnergyType = energyData["Oil"],
                                                    Amount = 50
                                                },
                                                new EnergyGenerationModel
                                                {
                                                    Country = countries["India"],
                                                    EnergyType = energyData["Solar"],
                                                    Amount = 50
                                                },
      new EnergyGenerationModel
      {
          Country = countries["India"],
          EnergyType = energyData["Wind"],
          Amount = 60
      },
       new EnergyGenerationModel
       {
           Country = countries["India"],
           EnergyType = energyData["Hydro"],
           Amount = 45
       },
        new EnergyGenerationModel
        {
            Country = countries["India"],
            EnergyType = energyData["Biomass"],
            Amount = 10
        },
         new EnergyGenerationModel
         {
             Country = countries["Russia"],
             EnergyType = energyData["Hydro"],
             Amount = 30
         },
          new EnergyGenerationModel
          {
              Country = countries["Russia"],
              EnergyType = energyData["Wind"],
              Amount = 5
          },
           new EnergyGenerationModel
           {
               Country = countries["Russia"],
               EnergyType = energyData["Biomass"],
               Amount = 4
           },

             new EnergyGenerationModel
             {
                 Country = countries["Germany"],
                 EnergyType = energyData["Solar"],
                 Amount = 60
             },
              new EnergyGenerationModel
              {
                  Country = countries["Germany"],
                  EnergyType = energyData["Wind"],
                  Amount = 70
              },
               new EnergyGenerationModel
               {
                   Country = countries["Germany"],
                   EnergyType = energyData["Biomass"],
                   Amount = 20
               },
                new EnergyGenerationModel
                {
                    Country = countries["Germany"],
                    EnergyType = energyData["Hydro"],
                    Amount = 10
                }


                    );

                    context.SaveChanges();
                }
            }
        }
    }
}


