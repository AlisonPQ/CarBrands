using CarBrands.BusinessLogic;
using CarBrands.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarBrands.Presentation.WebService.Controllers
{
    public class CarBrandsController : BaseApiController
    {
        private readonly ICarBrandService _carBrandService;
        public CarBrandsController(ICarBrandService carBrandService)
        {
            _carBrandService = carBrandService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CarBrand>>> GetCarBrands()
        {
            var carBrands = await _carBrandService.GetAllCarBrands();
            return Ok(carBrands);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarBrand>> GetCarBrand(Guid id)
        {
            return await _carBrandService.GetCarBrandById(id);
        }
    }
}