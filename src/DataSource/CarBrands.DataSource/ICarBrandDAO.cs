using CarBrands.Models;

namespace CarBrands.DataSource
{
    public interface ICarBrandDAO
    {
        Task<List<CarBrand>> GetAllCarBrands();
        Task<CarBrand> GetCarBrandById(Guid id);
    }
}