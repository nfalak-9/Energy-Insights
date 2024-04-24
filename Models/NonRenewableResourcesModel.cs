namespace Energy_Insights.Models
{
    public class NonRenewableResourcesModel
    {
        public string Country { get; set; } = string.Empty;
        public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();
    }
}

