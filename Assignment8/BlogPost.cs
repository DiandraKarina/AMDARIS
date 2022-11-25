using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment8
{
    public class BlogPost
    {
        public BlogPost(string categoryName, string recommendedTime, string blogName)
        {
            CategoryName = categoryName;
            RecommendedTime=recommendedTime;
            BlogName = blogName;
        }

        public string BlogName { get; set; }
        public string CategoryName { get; set; }
        public string RecommendedTime { get; set; }

    }
}

