using Application.Abstract;
using Application.Commands.BlogPosts;
using Application.Enums;
using Application.ErrorMessages;
using Application.Models;
using Domain.Exceptions;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Application.CommandHandler.BlogPosts
{
    public class AddCategoryToBlogPostCommandHandler : IRequestHandler<AddCategoryToBlogPostCommand, OperationResult<Category>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddCategoryToBlogPostCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<OperationResult<Category>> Handle(AddCategoryToBlogPostCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Category>();
            try
            {
                var blogpost = await _unitOfWork.BlogPostRepository.GetById(request.BlogPostId);
                var category = Category.CreateCategory(request.CategoryName);
                if (blogpost is null)
                {
                    result.AddError(ErrorCode.NotFound,
                        string.Format(BlogPostErrorMessage.BlogPostNotFound, request.BlogPostId));
                    return result;
                }

               // blogpost.CategoryId=category.CategoryId;
                blogpost.Categories.Add(category);
                await _unitOfWork.BlogPostRepository.Update(blogpost);
                await _unitOfWork.Save();

                result.Payload = category;

            }

            catch (Exception e)
            {
                result.AddUnknownError(e.Message);
            }

            return result;
        }
    }
}
