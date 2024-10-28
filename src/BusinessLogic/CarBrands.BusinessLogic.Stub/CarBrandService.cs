using CarBrands.DataSource;
using CarBrands.Models;

namespace CarBrands.BusinessLogic.Stub
{
    public class CarBrandService : ICarBrandService
    {
        private readonly ICarBrandDAO _carBrandDao;
        public CarBrandService(ICarBrandDAO carBrandDao)
        {
            _carBrandDao = carBrandDao;
        }
        public Task<List<CarBrand>> GetAllCarBrands()
        {
            return _carBrandDao.GetAllCarBrands();
        }

        public Task<CarBrand> GetCarBrandById(Guid id)
        {
            return _carBrandDao.GetCarBrandById(id);
        }
    }
}
