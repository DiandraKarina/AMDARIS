using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Comment
    {
        public int CommentId { get; set; }
        public string Message { get; set; }

        public int AuthorId { get; set; }

        public DateTime CommentDate { get; set; }

        public int BlogId { get; set; }

        public Comment()
        {
            CommentDate = DateTime.Now;
        }
    }
}
