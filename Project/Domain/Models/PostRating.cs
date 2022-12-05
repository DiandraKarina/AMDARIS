using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PostRating
    {
        public PostRating() { }
        public int BlogPostId { get; set; }
        public int UserId { get; set; }
        public int Stars { get; set; }

        public static PostRating CreatePostRating(int blogPostId, int stars, int userId)
        {
            return new PostRating
            {
                BlogPostId = blogPostId,
                UserId = userId,
                Stars = stars,
            };
        }
    }
}
