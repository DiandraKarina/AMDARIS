using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
          optionsBuilder.UseSqlServer("Server=DESKTOP-RLE2IV1;Database=BlogWebsite;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true;");
          }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
             base.OnModelCreating(modelBuilder);
        }
        

        
    }
}
