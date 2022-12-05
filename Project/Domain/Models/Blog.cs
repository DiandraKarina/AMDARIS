using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Blog
    {
        public Blog(int blogid, int userid)
        {
            this.BlogId = blogid;
            this.UserId = userid;

        }
        public string ProfilePhoto { get; set; }
        public string BlogName { get; set; }
        public int BlogId { get; set; }
        public int UserId { get; set; }

        public List<BlogPost> BlogPosts = new List<BlogPost>();

        public List<BlogRating> Ratings = new List<BlogRating>();

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

