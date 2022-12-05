using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Category
    {
        public Category(int categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public string GetData()
        {
            return Name;
        }
    }
}
