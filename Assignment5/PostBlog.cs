using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class PostBlog
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == String.Empty || value == null)
                {
                    throw new ArgumentNullException("Name cannot be null or empty string", "Name");
                }
                else
                {
                    name = value;
                }
            }
        }
    }
}
