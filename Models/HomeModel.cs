using System.ComponentModel.DataAnnotations.Schema;

namespace Energy_Insights.Models
{
    [NotMapped]
    public class HomeModel
    {
        public string Title { get; set; } = string.Empty;

        public string WelcomeMessage { get; set; } = string.Empty;
        public string LogoPath { get; set; } = string.Empty;
    }
}
