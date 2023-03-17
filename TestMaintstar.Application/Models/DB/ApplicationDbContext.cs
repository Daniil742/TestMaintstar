using Microsoft.EntityFrameworkCore;
using TestMaintstar.Application.Models.Entities;

namespace TestMaintstar.Application.Models.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Picture> Pictures { get; set; }
    }
}
