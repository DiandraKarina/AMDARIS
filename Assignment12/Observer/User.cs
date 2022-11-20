using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class User : IUser<BlogPost>
    {
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; }
        public string LastName { get; }

        public void NotifyRegisteredUser(BlogPost article)
        {
            Console.WriteLine(article.BlogName);
        }
    }
}
