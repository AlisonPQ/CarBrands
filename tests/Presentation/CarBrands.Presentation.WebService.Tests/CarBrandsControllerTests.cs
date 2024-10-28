using CarBrands.BusinessLogic;
using CarBrands.BusinessLogic.Stub;
using CarBrands.DataSource;
using CarBrands.DataSource.Memory;
using CarBrands.Models;
using CarBrands.Presentation.WebService.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;

namespace CarBrands.Presentation.WebService.Tests
{
    public class CarBrandsControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {
        [Fact]
        public async Task Controllers_GetAllCarBrands_IsNotNull_UsingMock()
        {
            Mock<ICarBrandService> _mockCarService = new Mock<ICarBrandService>();
            CarBrandsController _controller = new CarBrandsController(_mockCarService.Object);

            _mockCarService.Setup(service => service.GetAllCarBrands());

            var result = await _controller.GetCarBrands();

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Controllers_GetCarBrandsAreNotNull_UsingStub()
        {
            ICarBrandDAO carBrandDao = new CarBrandDAO();
            ICarBrandService carBranService = new CarBrandService(carBrandDao);
            CarBrandsController carBrandController = new CarBrandsController(carBranService);

            var result = await carBrandController.GetCarBrands();

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Controllers_GetAllCarBrands_UsingStub()
        {
            ICarBrandDAO carBrandDao = new CarBrandDAO();
            ICarBrandService carBranService = new CarBrandService(carBrandDao);
            CarBrandsController carBrandController = new CarBrandsController(carBranService);

            var result = await carBrandController.GetCarBrands();

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var carBrands = Assert.IsType<List<CarBrand>>(okResult.Value);
            Assert.Equal(3, carBrands.Count());
        }

        [Fact]
        public async Task Controllers_GetCarBrandById_UsingStub()
        {
            ICarBrandDAO carBrandDao = new CarBrandDAO();
            ICarBrandService carBranService = new CarBrandService(carBrandDao);
            CarBrandsController carBrandController = new CarBrandsController(carBranService);

            Guid id = Guid.Parse("54c797b1-b779-4396-9d1d-abeccc14a4e9");

            var result = await carBrandController.GetCarBrand(id);

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var carBrand = Assert.IsType<CarBrand>(okResult.Value);
            Assert.Equal("Toyota", carBrand.Name);
        }
    }
}