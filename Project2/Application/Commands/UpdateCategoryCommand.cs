﻿using Application.Models;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class UpdateCategoryCommand : IRequest<OperationResult<Category>>
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
