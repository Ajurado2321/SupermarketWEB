using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;

namespace SupermarketWEB.Data
{
    public class SupermarketContext : DbContext
    {
        public SupermarketContext(DbContextOptions options) : base(options)
        { 
        }
        public DbSet<Product> Porducts { get; set; }
        public DbSet<Category> Categories { get; set; }
		public object Provider { get; internal set; }
	}
}
