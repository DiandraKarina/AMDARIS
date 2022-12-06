using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Blog
    {
        private Blog() { }

        public string ProfilePhoto { get; set; }
        public string BlogName { get; set; }
        public int BlogId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public List<BlogPost> BlogPosts { get; set; }
        public List<BlogRating> Ratings { get; set; }

        public static Blog CreateBlog(int blogid, int userid)
        {
            return new Blog
            {
                BlogId = blogid,
                UserId = userid,
            };
        }
        public void AddBlogPost(BlogPost blogPost)
        {
            BlogPosts.Add(blogPost);
        }
        public void RemoveBlogPost(BlogPost blogPost)
        {
            BlogPosts.Remove(blogPost);
        }
        public void AddRating(BlogRating ratings)
        {
            Ratings.Add(ratings);
        }
        public double AverageRating(List<BlogRating> blogRatings)
        {
            double avg = blogRatings.Average(b => b.Stars);
            return avg;
        }
    }
}

