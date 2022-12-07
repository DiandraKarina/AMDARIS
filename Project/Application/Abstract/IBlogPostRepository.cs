using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstract
{
    public interface IBlogPostRepository
    {
        Task<BlogPost> GetById(int blogPostId);
        Task Add(BlogPost blogPost);
        Task Remove(BlogPost blogPost);
        Task<List<BlogPost>> GetAll();
        Task Update(BlogPost blogPost);
    }
}
