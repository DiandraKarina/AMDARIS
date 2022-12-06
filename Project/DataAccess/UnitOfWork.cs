using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context, IBlogRepository blogRepository, IBlogPostRepository blogPostRepository,
            IUserRepository userRepository)
        {
            _context = context;
            BlogRepository = blogRepository;
            BlogPostRepository = blogPostRepository;
            UserRepository = userRepository;
        }

        public IBlogRepository BlogRepository { get; private set; }
        public IBlogPostRepository BlogPostRepository { get; private set; }

        public IUserRepository UserRepository { get; private set; }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
