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
                var countries = new List<CountryModel >
                    {
                    new CountryModel { Name = "USA" },
                    new CountryModel { Name = "India" },
                    new CountryModel { Name = "China" },
                    new CountryModel { Name = "Russia" },
                    new CountryModel { Name = "Germany" }
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
                Dictionary<String, EnergyTypeModel > energyData = new Dictionary<String, EnergyTypeModel>();
                foreach( EnergyTypeModel e in  energyTypes)
                {
                    energyData.Add(e.Name, e);
                }


                context.EnergyGenerationModel.AddRange(

                    new EnergyGenerationModel { Country = new CountryModel { Name = "USA" },
                        EnergyType = energyData["Coal"],
                        Amount = 500
                     },
                     new EnergyGenerationModel
                     {
                         Country = new CountryModel { Name = "USA" },
                         EnergyType = energyData["Coal"],
                         Amount = 500
                     },
                      new EnergyGenerationModel
                      {
                          Country = new CountryModel { Name = "USA" },
                          EnergyType = energyData["Coal"],
                          Amount = 500
                      },
                       new EnergyGenerationModel
                       {
                           Country = new CountryModel { Name = "USA" },
                           EnergyType = energyData["Coal"],
                           Amount = 500
                       },
                        new EnergyGenerationModel
                        {
                            Country = new CountryModel { Name = "USA" },
                            EnergyType = energyData["Coal"],
                            Amount = 500
                        },
                         new EnergyGenerationModel
                         {
                             Country = new CountryModel { Name = "USA" },
                             EnergyType = energyData["Coal"],
                             Amount = 500
                         },
                          new EnergyGenerationModel
                          {
                              Country = new CountryModel { Name = "USA" },
                              EnergyType = energyData["Coal"],
                              Amount = 500
                          },
                           new EnergyGenerationModel
                           {
                               Country = new CountryModel { Name = "USA" },
                               EnergyType = energyData["Coal"],
                               Amount = 500
                           },
                            new EnergyGenerationModel
                            {
                                Country = new CountryModel { Name = "USA" },
                                EnergyType = energyData["Coal"],
                                Amount = 500
                            },
                             new EnergyGenerationModel
                             {
                                 Country = new CountryModel { Name = "USA" },
                                 EnergyType = energyData["Coal"],
                                 Amount = 500
                             },
                              new EnergyGenerationModel
                              {
                                  Country = new CountryModel { Name = "USA" },
                                  EnergyType = energyData["Coal"],
                                  Amount = 500
                              },
                               new EnergyGenerationModel
                               {
                                   Country = new CountryModel { Name = "USA" },
                                   EnergyType = energyData["Coal"],
                                   Amount = 500
                               },
                                new EnergyGenerationModel
                                {
                                    Country = new CountryModel { Name = "USA" },
                                    EnergyType = energyData["Coal"],
                                    Amount = 500
                                },
                                 new EnergyGenerationModel
                                 {
                                     Country = new CountryModel { Name = "USA" },
                                     EnergyType = energyData["Coal"],
                                     Amount = 500
                                 },
                                  new EnergyGenerationModel
                                  {
                                      Country = new CountryModel { Name = "USA" },
                                      EnergyType = energyData["Coal"],
                                      Amount = 500
                                  },
                                   new EnergyGenerationModel
                                   {
                                       Country = new CountryModel { Name = "USA" },
                                       EnergyType = energyData["Coal"],
                                       Amount = 500
                                   }






                );

                context.SaveChanges();
            }
        }


