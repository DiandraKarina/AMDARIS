using Application.Commands;
using DataAccess;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CommandHandlers
{
    public class RemoveBlogPostFromBlogHandler : IRequestHandler<RemoveBlogPostFromBlog, Blog>
    {
        private readonly IUnitOfWork _unitOfWork;
        public RemoveBlogPostFromBlogHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Blog> Handle(RemoveBlogPostFromBlog request, CancellationToken cancellationToken)
        {
            var blog = await _unitOfWork.BlogRepository.GetById(request.BlogId);
            var blogpost = await _unitOfWork.BlogPostRepository.GetById(request.BlogPostId);

            if (blog == null || blogpost == null)
            {
                return null;
            }

            blog.BlogPosts.Remove(blogpost);
            await _unitOfWork.Save();

            return blog;
        }
    }
}
