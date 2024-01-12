using Microsoft.EntityFrameworkCore;
using TestShared.Model;

namespace TestRestAPI.Repository
{
    public class TutorialRepository(DbContextOptions<TutorialRepository> options) : DbContext(options)
    {
        public DbSet<Base> Base { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<Users> Users { get; set; }
    }
}
