using Microsoft.EntityFrameworkCore;
using Skill_International.Models;

namespace Skill_International
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;database=skill_db");
        }


        public DbSet<StudentModel> Registration { get; set; }
        public DbSet<LoginModel> Logins { get; set; }
    }
}
