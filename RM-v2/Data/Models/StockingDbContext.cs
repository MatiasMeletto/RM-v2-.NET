using Microsoft.EntityFrameworkCore;
using RM_v2.Objects;

namespace RM_v2.Data.Models
{
    public class StockingDbContext : DbContext
    {
        public DbSet<Accesorio> accesorios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=stock.db");
    }
}
