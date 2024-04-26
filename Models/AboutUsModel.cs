using System.ComponentModel.DataAnnotations.Schema;

namespace Energy_Insights.Models
{
    [NotMapped]
    public class AboutUsModel 
    {
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
