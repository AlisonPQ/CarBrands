using CarBrands.Models;
using Microsoft.EntityFrameworkCore;

namespace CarBrands.DataSource.PostgreSQL
{
    public class CarBrandDAO : ICarBrandDAO
    {
        private readonly DataContext _context;
        public CarBrandDAO(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CarBrand>> GetAllCarBrands()
        {
            return await _context.CarBrands.ToListAsync();
        }

        public async Task<CarBrand> GetCarBrandById(Guid id)
        {
            return await _context.CarBrands.FindAsync(id);
        }
    }
}
