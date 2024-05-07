using Inventory_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Management_System.DataBase
{
    public class ImsDbContext : DbContext
    {
        public ImsDbContext(DbContextOptions options) : base(options)
        {
        }
        public  DbSet<Product> Products { get; set; } = default!;
		public DbSet<Inventory_Management_System.Models.Sales> Sales { get; set; } = default!;
    }
}
