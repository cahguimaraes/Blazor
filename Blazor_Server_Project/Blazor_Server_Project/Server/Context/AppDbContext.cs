using Blazor_Server_Project.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Server_Project.Server.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
