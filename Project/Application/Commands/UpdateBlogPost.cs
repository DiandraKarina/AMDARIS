using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class UpdateBlogPost:IRequest<BlogPost>
    {
        public int BlogPostId { get; set; }
        public string Image { get; set; }
        public string PostName { get; set; }
        public string Description { get; set; }
    }
}
