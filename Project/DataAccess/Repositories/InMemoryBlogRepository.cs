using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class InMemoryBlogRepository
    {
        private readonly List<Blog> _blogs = new();

        public void CreateBlog(Blog blog)
        {
            _blogs.Add(blog);
            blog.BlogId = _blogs.Count;
        }

        public void AddPostToBlog(int blogId, BlogPost blogpost)
        {
            var blog = _blogs.FirstOrDefault(b => b.BlogId == blogId);
            if (blog == null) throw new InvalidOperationException($"Blog with id {blogId} not found");

            blog.AddBlogPost(blogpost);
        }

        public void DeleteBlogPost(int blogId, int blogPostId)
        {
            var blog = _blogs.FirstOrDefault(b => b.BlogId == blogId);
            if (blog == null) throw new InvalidOperationException($"Blog with id {blogId} not found");

            var post = blog.BlogPosts.FirstOrDefault(bp => bp.BlogPostId == blogPostId);
            if (post == null) throw new InvalidOperationException($"Blogpost with id {blogPostId} not found");

            blog.RemoveBlogPost(post);
        }

        public Blog GetBlog(int id)
        {
            return _blogs.FirstOrDefault(bp => bp.BlogId == id);
        }

        public IEnumerable<Blog> GetBlogs()
        {
            return _blogs;
        }


    }
}
