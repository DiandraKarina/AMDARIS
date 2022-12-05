using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BlogPost
    {
        public BlogPost() { }
        public string Image { get; set; }
        public string PostName { get; set; }
        public string Description { get; set; }
        public int BlogPostId { get; set; }
        public int BlogId { get; set; }
        public int PostRatingId { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<PostRating> PostRatingList=new List<PostRating>();

        public List<Comment> Comments = new List<Comment>();
        public Category Category { get; set; }

        //Factory
        public static BlogPost CreateBlogpost(int blogId, Category category, string image,string postName)
        {
            return new BlogPost
            {
                BlogId = blogId,
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

            PostRatingList.Add(postRating);
        }

        public double AverageRating(List<PostRating> postRatings)
        {
            double avg = postRatings.Average(b => b.Stars);
            return avg;
        }

        
    }
}
