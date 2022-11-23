using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Comment
    {
        public Comment()
        {
            CommentDate = DateTime.Now;
        }
        public int CommentId { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public DateTime CommentDate { get; set; }
        public int BlogPostId { get; set; }

        
    }
}
