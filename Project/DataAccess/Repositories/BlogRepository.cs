using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly DataContext _context;
        public BlogRepository(DataContext context)
        {
            _context = context;
        }
        public async Task Add(Blog blog)
        {
            await _context.Blogs.AddAsync(blog);
        }
        public async Task<IEnumerable<Blog>> GetAll()
        {
            return await _context.Blogs
                .Take(100)
                .ToListAsync();
        }
        public async Task<Blog> GetById(int blogId)
        {
            var blog = await _context.Blogs
                .SingleOrDefaultAsync(bp => bp.BlogId == blogId);
            return blog;
        }
        public async Task Remove(Blog blog)
        {
            _context.Blogs.Remove(blog);
        }

        public async Task Update(Blog blog)
        {
            _context.Update(blog);
        }
    }
}
