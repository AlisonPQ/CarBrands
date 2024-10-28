using CarBrands.BusinessLogic.Stub;
using CarBrands.DataSource;
using CarBrands.DataSource.Memory;
using Moq;

namespace CarBrands.BusinessLogic.Tests
{
    public class CarBrandsServiceTests
    {
        [Fact]
        public void Service_Get_AllCarBrands_UsingMock()
        {
            var mockCarBrandDao = new Mock<ICarBrandDAO>();
            var carBrandService = new CarBrandService(mockCarBrandDao.Object);

            var carBrands = carBrandService.GetAllCarBrands();

            Assert.NotNull(carBrands);
        }

        [Fact]
        public async void Service_Get_AllCarBrands_UsingMemory()
        {
            var carBrandDao = new CarBrandDAO();
            var carBrandService = new CarBrandService(carBrandDao);

            var carBrands = await carBrandService.GetAllCarBrands();

            Assert.Equal(3, carBrands.Count());
        }

        [Fact]
        public async void Service_Get_CarBrandsById_UsingMemory()
        {
            var carBrandDao = new CarBrandDAO();
            var carBrandService = new CarBrandService(carBrandDao);

            Guid id = Guid.Parse("54c797b1-b779-4396-9d1d-abeccc14a4e9");

            var carBrand = await carBrandService.GetCarBrandById(id);

            Assert.Equal("Toyota", carBrand.Name);
        }
    }
}