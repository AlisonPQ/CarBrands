using CarBrands.DataSource.Memory;
using CarBrands.Models;

namespace CarBrands.DataSource.Tests
{
    public class CarBrandsDaoTests
    {
        [Fact]
        public async void Dao_Get_AllCarBrands()
        {
            ICarBrandDAO carBrandDao = new CarBrandDAO();

            var carBrands = await carBrandDao.GetAllCarBrands();

            Assert.NotNull(carBrands);
            Assert.Equal(3, carBrands.Count());
        }

        [Fact]
        public async void Get_CarBrandById()
        {
            ICarBrandDAO carBrandDao = new CarBrandDAO();

            Guid id = Guid.Parse("54c797b1-b779-4396-9d1d-abeccc14a4e9");
            CarBrand carBrand = await carBrandDao.GetCarBrandById(id);

            Assert.Equal("Toyota", carBrand.Name);
        }
    }
}