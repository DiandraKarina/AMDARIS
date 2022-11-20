using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class AbstractPublisher<T>
    {
        private List<IUser<T>> users;
        public AbstractPublisher()
        {
            this.users = new List<IUser<T>>();
        }

        public void AddUser(IUser<T> user)
        {
            this.users.Add(user);
        }
        public void Post(T article)
        {
            this.users.ForEach(u => u.NotifyRegisteredUsers(article));
        }
    }
}
