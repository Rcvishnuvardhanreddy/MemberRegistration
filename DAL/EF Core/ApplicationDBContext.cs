using Microsoft.EntityFrameworkCore;
using MemberRegistration.DAL.Entities;
using System.Reflection;

namespace MemberRegistration.DAL
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<UsersEntity> UsersEntity { get; set; }

        public DbSet<MembersEntity> MembersEntity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=MembersRegistrationDb.db", options =>
            {
                options.MigrationsAssembly("MemberRegistration");
            });

            base.OnConfiguring(optionsBuilder);
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

    }
}
