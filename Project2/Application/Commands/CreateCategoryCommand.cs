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
    public class CreateCategoryCommand : IRequest<OperationResult<Category>>
    {
        public string CategoryName { get; set; }
       
    }
}
