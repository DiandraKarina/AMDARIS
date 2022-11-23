using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PostRating
    {
        public int BlogPostId { get; set; }
        public int UserId { get; set; }
        public int Stars { get; set; }
    }
}
