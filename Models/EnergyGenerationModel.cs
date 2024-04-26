using System.Diagnostics.Metrics;

namespace Energy_Insights.Models
{
    public class EnergyGenerationModel
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int EnergyTypeId { get; set; }
        public double Amount { get; set; }

        // Navigation properties
        public CountryModel Country { get; set; }
        public EnergyTypeModel EnergyType { get; set; }
    }
}
