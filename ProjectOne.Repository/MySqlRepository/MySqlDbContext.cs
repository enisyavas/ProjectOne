
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace ProjectOne.Repository{
    public class MySqlDbContext : DbContext
    {
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
        {
        }

        
    }
}