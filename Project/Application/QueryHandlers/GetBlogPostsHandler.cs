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
    public class GetBlogPostsHandler : IRequestHandler<GetBlogPostsQuery, List<BlogPost>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetBlogPostsHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<BlogPost>> Handle(GetBlogPostsQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.BlogPostRepository.GetAll();
        }
    }
}
