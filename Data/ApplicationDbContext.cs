using Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opttions)
            : base(opttions) { }

        public DbSet<User> users { get; set; }

    }
}
