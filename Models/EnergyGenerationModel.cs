using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Energy_Insights.Models
{
    public class EnergyGenerationModel
    {
        public int Id { get; set; }
        [Required]
        public int CountryId { get; set; }
        [Required]
        public int EnergyTypeId { get; set; }
        [Required]
        [DataType("double")]
        public double Amount { get; set; }

        // Navigation properties
        public CountryModel Country { get; set; }
        public EnergyTypeModel EnergyType { get; set; }
    }
}
