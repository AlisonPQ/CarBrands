using CarBrands.Models;
using Microsoft.EntityFrameworkCore;

namespace CarBrands.DataSource.PostgreSQL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<CarBrand> CarBrands { get; set; }
    }
}