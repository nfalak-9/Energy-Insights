using System.ComponentModel.DataAnnotations.Schema;

namespace Energy_Insights.Models
{
    [NotMapped]
    public class RenewableResourcesModel
    {
        public string Country { get; set; } = string.Empty;
        public Dictionary<string, string> EnergyTypes { get; set; } = new Dictionary<string, string>();
    }
}
