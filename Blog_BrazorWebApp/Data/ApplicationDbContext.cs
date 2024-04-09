using Blog_BrazorWebApp.Model;
using Microsoft.EntityFrameworkCore;

namespace Blog_BrazorWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<UserRole> Roles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(
                            new Article { Id = 1, Title = "タイトル１", Content = "本文１", CreateDate = DateTime.Now, UpdateDate = DateTime.Now, UserId = 1 },
                            new Article { Id = 2, Title = "タイトル２", Content = "本文２", CreateDate = DateTime.Now, UpdateDate = DateTime.Now, UserId = 1 },
                            new Article { Id = 3, Title = "タイトル３", Content = "本文３", CreateDate = DateTime.Now, UpdateDate = DateTime.Now, UserId = 2 }
                        );

            modelBuilder.Entity<UserAccount>().HasData(
                new UserAccount { Id = 1, UserName = "admin@test.com", Password = "adminpass", RoleId = 1 },
                new UserAccount { Id = 2, UserName = "user@test.com", Password = "userpass", RoleId = 2 }
            );

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { Id = 1, RoleName = "administrator" },
                new UserRole { Id = 2, RoleName = "user" }
            );

        }
    }
}
