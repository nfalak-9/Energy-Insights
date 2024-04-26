namespace Energy_Insights.Models
{
    public class EnergyTypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        // Navigation property
        public ICollection<EnergyGenerationModel> EnergyGenerations { get; set; }
    }
}
