using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class DeleteBlog:IRequest<Blog>
    {
        public int BlogId { get; set; }
    }
}
