using Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        public IBlogRepository BlogRepository { get; }
        public IBlogPostRepository BlogPostRepository { get; }
        public IUserRepository UserRepository { get; }
        Task Save();
    }
}
