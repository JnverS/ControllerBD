using Microsoft.EntityFrameworkCore;
using ControllerBD.Models;


    public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
       // Database.EnsureCreated();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
                new User { Id = 1, NickName = "Tom", Lvl = 37, TotalScore = 10500 },
                new User { Id = 2, NickName = "Bob", Lvl = 41, TotalScore = 50000 },
                new User { Id = 3, NickName = "Sam", Lvl = 24, TotalScore = 5000 }
        );
    }
}
