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
    public class GetBlogsHandler : IRequestHandler<GetBlogsQuery, List<Blog>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetBlogsHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<Blog>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.BlogRepository.GetAll();
        }
    }
}
