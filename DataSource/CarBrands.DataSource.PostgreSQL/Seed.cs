using CarBrands.Models;

namespace CarBrands.DataSource.PostgreSQL
{
    public class Seed
    {
        public static async Task SeedData(DataContext dataContext)
        {
            if (dataContext.CarBrands.Any()) return;

            var carBrands = new List<CarBrand>
            {
                new CarBrand
                {
                    Id = Guid.NewGuid(),
                    Name = "Toyota",
                    CountryOfOrigin = "Japan",
                    FoundedYear = 1937,
                    WebSite = "https://www.toyota.com",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/7/78/Toyota_Logo.svg"
                },
                    new CarBrand
                {
                    Id = Guid.NewGuid(),
                    Name = "Ford",
                    CountryOfOrigin = "United States",
                    FoundedYear = 1903,
                    WebSite = "https://www.ford.com",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Ford_logo_flat.svg/1200px-Ford_logo_flat.svg.png"
                },
                new CarBrand
                    {
                    Id = Guid.NewGuid(),
                    Name = "Volkswagen",
                    CountryOfOrigin = "Germany",
                    FoundedYear = 1937,
                    WebSite = "https://www.volkswagen.com",
                    Logo = "https://uploads.vw-mms.de/system/production/images/vwn/030/145/images/7a0d84d3b718c9a621100e43e581278433114c82/DB2019AL01950_web_1160.jpg?1649155356"
                },
                new CarBrand
                {
                    Id = Guid.NewGuid(),
                    Name = "Honda",
                    CountryOfOrigin = "Japan",
                    FoundedYear = 1948,
                    WebSite = "https://www.honda.com",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/7/7b/Honda_Logo.svg"
                },
                new CarBrand
                {
                    Id = Guid.NewGuid(),
                    Name = "Mercedes-Benz",
                    CountryOfOrigin = "Germany",
                    FoundedYear = 1926,
                    WebSite = "https://www.mercedes-benz.com",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/e/e6/Mercedes-Benz_logo_2.svg"
                },
                new CarBrand
                {
                    Id = Guid.NewGuid(),
                    Name = "Nissan",
                    CountryOfOrigin = "Japan",
                    FoundedYear = 1933,
                    WebSite = "https://www.nissan-global.com",
                    Logo = "https://hips.hearstapps.com/hmg-prod/images/nissan-brand-logo-1200x938-1594842787.jpg"
                },
                new CarBrand
                {
                    Id = Guid.NewGuid(),
                    Name = "Chevrolet",
                    CountryOfOrigin = "United States",
                    FoundedYear = 1911,
                    WebSite = "https://www.chevrolet.com",
                    Logo = "https://www.carlogos.org/logo/Chevrolet-logo-2013-2560x1440.png"
                },
                new CarBrand
                {
                    Id = Guid.NewGuid(),
                    Name = "Hyundai",
                    CountryOfOrigin = "South Korea",
                    FoundedYear = 1967,
                    WebSite = "https://www.hyundai.com",
                    Logo = "https://logodownload.org/wp-content/uploads/2014/05/hyundai-logo-0.png"
                }
            };

            await dataContext.CarBrands.AddRangeAsync(carBrands);
            await dataContext.SaveChangesAsync();
        }
    }
}