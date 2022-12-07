using Application.Abstract;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly DataContext _context;
        public BlogPostRepository(DataContext context)
        {
            _context = context;
        }
        public async Task Add(BlogPost blogPost)
        {
            await _context.BlogPosts.AddAsync(blogPost);
        }
        public async Task<List<BlogPost>> GetAll()
        {
            return await _context.BlogPosts
                .Take(100)
                .ToListAsync();
        }
        public async Task<BlogPost> GetById(int blogPostId)
        {
            var blogPost = await _context.BlogPosts
                .SingleOrDefaultAsync(bp => bp.BlogPostId == blogPostId);
            return blogPost;
        }
        public async Task Remove(BlogPost blogPost)
        {
            _context.BlogPosts.Remove(blogPost);
        }

        public async Task Update(BlogPost blogPost)
        {
            _context.Update(blogPost);
        }
    }
}
