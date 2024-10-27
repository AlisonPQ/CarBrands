using CarBrands.Models;

namespace CarBrands.BusinessLogic
{
    public interface ICarBrandService
    {
        Task<IEnumerable<CarBrand>> GetAllCarBrands();
        Task<CarBrand> GetCarBrandById(Guid id);
    }
}
