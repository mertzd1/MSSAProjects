using Microsoft.EntityFrameworkCore;

namespace customersDAO
{
    public class customersContext : DbContext
    {
        public DbSet<customers> customerss { get; set; }
        public DbSet<contacts> contactss { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=customersging.db");
    }
}
