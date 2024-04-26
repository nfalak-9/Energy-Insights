using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Energy_Insights.Models;

namespace Energy_Insights.Data
{
    public class Energy_InsightsContext : DbContext
    {
        public Energy_InsightsContext (DbContextOptions<Energy_InsightsContext> options)
            : base(options)
        {
        }

        public DbSet<Energy_Insights.Models.EnergyGenerationModel> EnergyGenerationModel { get; set; } = default!;
    }
}
