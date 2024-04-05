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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(
                new Article { Id = 1, Title = "タイトル１", Content = "本文１", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new Article { Id = 2, Title = "タイトル２", Content = "本文２", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new Article { Id = 3, Title = "タイトル３", Content = "本文３", CreateDate = DateTime.Now, UpdateDate = DateTime.Now }
            );
        }
    }
}
