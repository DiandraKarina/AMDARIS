using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstract
{
    public interface IUserRepository
    {
        Task<User> GetById(int userId);
        Task Add(User user);
        Task Remove(User user);
        Task <IEnumerable<User>> GetAll();
        Task Update(User user);
    }
}
