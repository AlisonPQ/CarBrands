using CarBrands.DataSource;
using CarBrands.Models;

namespace CarBrands.BusinessLogic.Impl
{
    public class CarBrandService : ICarBrandService
    {
        private readonly ICarBrandDAO _carBrandDAO;
        public CarBrandService(ICarBrandDAO carBrandDAO)
        {
            _carBrandDAO = carBrandDAO;
        }
        public Task<IEnumerable<CarBrand>> GetAllCarBrands()
        {
            return _carBrandDAO.GetAllCarBrands();
        }

        public Task<CarBrand> GetCarBrandById(Guid id)
        {
            return _carBrandDAO.GetCarBrandById(id);
        }
    }
}