using CarBrands.Models;

namespace CarBrands.BusinessLogic.Stub
{
    public class CarBrandService : ICarBrandService
    {
        private readonly ICarBrandService _carBrandService;
        public CarBrandService(ICarBrandService carBrandService)
        {
            _carBrandService = carBrandService;
        }
        public Task<IEnumerable<CarBrand>> GetAllCarBrands()
        {
            return _carBrandService.GetAllCarBrands();
        }

        public Task<CarBrand> GetCarBrandById(Guid id)
        {
            return _carBrandService.GetCarBrandById(id);
        }
    }
}
