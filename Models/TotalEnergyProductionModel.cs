namespace Energy_Insights.Models
{
    public class TotalEnergyProductionModel
    {
        public string Country { get; set; } = string.Empty;
        public double TotalEnergy { get; set; }
        public double RenewableEnergy { get; set; }
        public double NonrenewableEnergy { get; set; }
    }
}
