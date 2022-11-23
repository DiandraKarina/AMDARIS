using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Blog
    {
        public Blog(int blogid, int userid, List<Category> categoriess)
        {
            this.BlogId = blogid;
            this.UserId = userid;
            this.categories = categoriess;
        }
        public int BlogId { get; set; }
        public int UserId { get; set; }

        public List<BlogPost> posts = new List<BlogPost>();

        public List<Category> categories = new List<Category>();

        public void AddBlogPost(BlogPost blogpost) { }
        public void RemoveBlogPost(BlogPost blogpost) { }
        public void AverageRating(List<BlogRating> ratings) { } //lista de blograting
    }
}

