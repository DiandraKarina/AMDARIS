using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;


namespace DataAccess
{
    public class InMemoryBlogPostRepository
    {
        private readonly List<BlogPost> _blogposts = new();
        private readonly List<Category> _categories = new();
        public InMemoryBlogPostRepository()
        {
            BlogPost.CreateBlogpost(1, _categories[0], "imageurl", "Banana Pancakes");
            BlogPost.CreateBlogpost(2, _categories[1], "imageurl2", "Sushi Bowl");
            BlogPost.CreateBlogpost(3, _categories[2], "imageurl3", "Fish and Chips");
        }

        public void CreateBlogPost(BlogPost blogpost)
        {
            blogpost.BlogPostId = _blogposts.Count + 1;
            _blogposts.Add(blogpost);
        }

        public BlogPost GetBlogPost(int id)
        {
            return _blogposts.FirstOrDefault(bp => bp.BlogPostId == id);
        }

        public IEnumerable<BlogPost> GetBlogPosts()
        {
            return _blogposts;
        }
            
    }
}
