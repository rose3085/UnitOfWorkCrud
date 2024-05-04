using Microsoft.EntityFrameworkCore;
using UnitOfWorkCrud.Model;

namespace UnitOfWorkCrud.Data
{
    public class ApplicationDbContext : DbContext
    {



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }


        public DbSet<UserModel> User { get; set; }
    }
}
