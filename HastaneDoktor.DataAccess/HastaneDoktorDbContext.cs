using HastaneDoktor.Entities;
using Microsoft.EntityFrameworkCore;

namespace HastaneDoktor.DataAccess
{
    public class HastaneDoktorDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Server=DESKTOP-IK7PVOC; Database=HastaneDB; ");
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-IK7PVOC; Initial Catalog=HastaneDB2; Integrated Security=true");

        }

        public  DbSet<Doktor> Doktor { get; set; }
        public DbSet<Hastane> Hastanes { get; set; }

    }
}
