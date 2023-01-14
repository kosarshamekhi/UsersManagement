using Microsoft.EntityFrameworkCore;
using UsersManagement.Model.Notes.Entities;
using UsersManagement.Model.Users.Entities;

namespace UsersManagement.DAL.DbContexts;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Note> Notes { get; set; }

    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        modelBuilder.Seed();
    }
}
