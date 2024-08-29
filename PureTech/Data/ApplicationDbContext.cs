using Microsoft.EntityFrameworkCore;
using PureTech.Models;

namespace PureTech.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
    }
}
