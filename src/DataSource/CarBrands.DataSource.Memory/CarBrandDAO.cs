using CarBrands.Models;

namespace CarBrands.DataSource.Memory
{
    public class CarBrandDAO : ICarBrandDAO
    {
        public static List<CarBrand> ListCarBrands { get; set; }

        public CarBrandDAO()
        {
            ListCarBrands = new List<CarBrand>()
            {
                new CarBrand
                {
                    Id = Guid.Parse("54c797b1-b779-4396-9d1d-abeccc14a4e9"),
                    Name = "Toyota",
                    CountryOfOrigin = "Japan",
                    FoundedYear = 1937,
                    WebSite = "https://www.toyota.com",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/7/78/Toyota_Logo.svg"
                },
                new CarBrand
                {
                    Id = Guid.Parse("63ae9335-a8d1-4031-9b1e-547ba8e917f2"),
                    Name = "Ford",
                    CountryOfOrigin = "United States",
                    FoundedYear = 1903,
                    WebSite = "https://www.ford.com",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Ford_logo_flat.svg/1200px-Ford_logo_flat.svg.png"
                },
                new CarBrand
                    {
                    Id = Guid.Parse("b0aded39-cd12-45f4-a6cf-b29d1062c4b6"),
                    Name = "Volkswagen",
                    CountryOfOrigin = "Germany",
                    FoundedYear = 1937,
                    WebSite = "https://www.volkswagen.com",
                    Logo = "https://uploads.vw-mms.de/system/production/images/vwn/030/145/images/7a0d84d3b718c9a621100e43e581278433114c82/DB2019AL01950_web_1160.jpg?1649155356"
                }
            };
        }

        public Task<List<CarBrand>> GetAllCarBrands()
        {
            return Task.FromResult<List<CarBrand>>(ListCarBrands);
        }
        
        public Task<CarBrand> GetCarBrandById(Guid id)
        {
            var carBrand = ListCarBrands.FirstOrDefault(cb => cb.Id == id);
            return Task.FromResult(carBrand);
        }
    }
}
