using Application.Queries;
using DataAccess;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.QueryHandlers
{
        public class GetBlogPostByIdHandler : IRequestHandler<GetBlogPostByIdQuery, BlogPost>
        {
            private readonly IUnitOfWork _unitOfWork;
            public GetBlogPostByIdHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<BlogPost> Handle(GetBlogPostByIdQuery request, CancellationToken cancellationToken)
            {

                var blogpost = await _unitOfWork.BlogPostRepository.GetById(request.BlogPostId);

                return blogpost;
            }
        }
    
}
