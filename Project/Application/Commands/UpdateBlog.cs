﻿using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class UpdateBlog:IRequest<Blog>
    {
        public int BlogId { get; set; }
        public string ProfilePhoto { get; set; }
        public string BlogName { get; set; }

    }
}
