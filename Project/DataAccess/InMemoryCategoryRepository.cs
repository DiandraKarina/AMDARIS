using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace DataAccess
{
    public class InMemoryCategoryRepository
    {
        private readonly List<Category> _categories = new List<Category>();

        public InMemoryCategoryRepository()
        {
            _categories = new List<Category>()
            {
                new(1,"Breakfast"),
                new(2,"Brunch"),
                new(3,"Lunch"),
                new(4,"Dinner"),
                new(5,"Dessert")
            };
        }

        public Category GetCategories(int id)
        {
            return _categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }
    }
}
