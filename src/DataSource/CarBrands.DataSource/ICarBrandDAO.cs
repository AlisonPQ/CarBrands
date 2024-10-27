using CarBrands.Models;

namespace CarBrands.DataSource
{
    public interface ICarBrandDAO
    {
        Task<IEnumerable<CarBrand>> GetAllCarBrands();
        Task<CarBrand> GetCarBrandById(Guid id);
    }
}