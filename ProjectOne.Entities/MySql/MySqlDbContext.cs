
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace ProjectOne.Entity.MySql{
    public class MySqlDbContext : DbContext
    {

        public DbSet<User> Users{get;set;}
        public DbSet<Product> Products{get;set;}
        public DbSet<Payment> Payments{get;set;}
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}