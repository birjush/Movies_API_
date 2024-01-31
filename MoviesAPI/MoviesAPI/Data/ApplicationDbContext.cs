using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Movies> movies { get; set; }
        public DbSet<User> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>().HasData(
                    new Movies { ID = 1, Country = "India", Director = "Unknown", Genre = "Patriotic", Industry = "Unknown", Name = "Chanakya", Synopsis = "Lorem Ipsum" },
                    new Movies { ID = 2, Country = "India", Director = "Unknown", Genre = "Patriotic", Industry = "Unknown", Name = "Chanakya", Synopsis = "Lorem Ipsum" },
                    new Movies { ID = 3, Country = "India", Director = "Unknown", Genre = "Patriotic", Industry = "Unknown", Name = "Chanakya", Synopsis = "Lorem Ipsum" },
                    new Movies { ID = 4, Country = "India", Director = "Unknown", Genre = "Patriotic", Industry = "Unknown", Name = "Chanakya", Synopsis = "Lorem Ipsum" },
                    new Movies { ID = 5, Country = "India", Director = "Unknown", Genre = "Patriotic", Industry = "Unknown", Name = "Chanakya", Synopsis = "Lorem Ipsum" }
                );
            modelBuilder.Entity<User>().HasData(
                    new User { Key = "User1", Email = "user1@gmail.com", Password = "user1" },
                    new User { Key = "User2", Email = "user2@gmail.com", Password = "user2" },
                    new User { Key = "User3", Email = "user3@gmail.com", Password = "user3" }
                );
        }
    }
}
