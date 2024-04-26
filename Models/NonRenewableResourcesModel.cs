using System.ComponentModel.DataAnnotations.Schema;

namespace Energy_Insights.Models
{
    [NotMapped]
    public class NonRenewableResourcesModel
    {
        public string Country { get; set; } = string.Empty;
        public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();
    }
}

