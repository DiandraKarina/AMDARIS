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
    public class GetBlogByIdHandler : IRequestHandler<GetBlogByIdQuery, Blog>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetBlogByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Blog> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {

            var blog = await _unitOfWork.BlogRepository.GetById(request.BlogId);

            return blog;
        }
    }
}
