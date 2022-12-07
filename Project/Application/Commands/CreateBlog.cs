using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using MediatR;

namespace Application.Commands
{
    public class CreateBlog:IRequest<Blog>
    {
        public string ProfilePhoto { get; set; }
        public string BlogName { get; set; }
       // public int UserId { get; set; }
       // public virtual User User { get; set; }
    }
}
