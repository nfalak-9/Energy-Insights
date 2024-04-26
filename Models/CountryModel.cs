namespace Energy_Insights.Models
{
    public class CountryModel
    {
        public int Id { get; set; }
        public string Name { get; set; } 

        public ICollection<EnergyGenerationModel> EnergyGenerations { get; set; }

    }
}
