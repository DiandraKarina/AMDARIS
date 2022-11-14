using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Blog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }

        public string BlogCategory { get; set; }

        public DateTime BlogDate { get; set; }

        public Blog()
        {
            BlogDate = DateTime.Now;
        }
    }
}