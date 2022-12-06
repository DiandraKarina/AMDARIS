using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Comment
    {
        private Comment() { }
        public int CommentId { get; set; }
        public string Message { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public DateTime CommentDate { get; set; }
        public BlogPost BlogPost{ get; set; }

        public static Comment CreateComment(BlogPost blogPost,string message,int userId)
        {
            return new Comment
            {
                BlogPost = blogPost,
                Message = message,
                UserId = userId,
                CommentDate = DateTime.Now,
            };
        }

        
    }
}
