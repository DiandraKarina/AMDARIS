using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Configurations;

namespace DataAccess
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AddCommentConfig());
            builder.ApplyConfiguration(new AddBlogPostConfig());
            builder.ApplyConfiguration(new CreateBlogConfig());
            builder.ApplyConfiguration(new AddPostRatingConfig());
            builder.ApplyConfiguration(new AddBlogRatingConfig());
        }
    }
}
