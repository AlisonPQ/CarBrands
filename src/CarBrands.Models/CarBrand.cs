namespace CarBrands.Models
{
    public class CarBrand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public int FoundedYear { get; set; }
        public string WebSite { get; set; }
        public string Logo { get; set; }
    }
}
