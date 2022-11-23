using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BlogPost
    {
        public string PostName { get; set; }
        public int BlogId { get; set; }
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } //****
        public int PostRatingId { get; set; }
        public DateTime CreatedDate { get; set; }

        public BlogPost()
        {
            CreatedDate = DateTime.Now;
        }

        public string AddComment(Comment comment)
        { 
            return comment.Message; 
        }
        public void RemoveComment(Comment comment) 
        {
            Console.WriteLine($"comment {comment.CommentId} has been deleted");
        }
        public void AddRating(PostRating post_rating) { }
    }
}
