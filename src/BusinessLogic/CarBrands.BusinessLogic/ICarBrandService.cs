using CarBrands.Models;

namespace CarBrands.BusinessLogic
{
    public interface ICarBrandService
    {
        Task<List<CarBrand>> GetAllCarBrands();
        Task<CarBrand> GetCarBrandById(Guid id);
    }
}
