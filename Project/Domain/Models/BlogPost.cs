using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BlogPost
    {
        private BlogPost() { }
        public string Image { get; set; }
        public string PostName { get; set; }
        public string Description { get; set; }
        public int BlogPostId { get; set; }
        public Blog Blog { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<PostRating> PostRatings { get; set; }
        public List<Comment> Comments { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //Factory
        public static BlogPost CreateBlogpost(Blog blog, Category category, string image,string postName)
        {
            return new BlogPost
            {
                Blog = blog,
                Category=category,
                Image = image,
                PostName = postName,
                CreatedDate = DateTime.Now,
            };
        }
        public void AddComment(Comment newComment)
        {
            Comments.Add(newComment);
            CreatedDate = DateTime.Now;
        }
        public void RemoveComment(Comment delComment)
        {
            Comments.Remove(delComment);
        }
        public void AddRating(PostRating postRating)
        {

            PostRatings.Add(postRating);
        }

        public double AverageRating(List<PostRating> postRatings)
        {
            double avg = postRatings.Average(b => b.Stars);
            return avg;
        }

        
    }
}
