using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class ListManager
    {
        public static List<Comment> LoadComments_1()
        {
            List<Comment> list = new List<Comment>();

            list.Add(new Comment() { AuthorId = 065, BlogId = 12, CommentDate = Convert.ToDateTime("9/14/2021"), CommentId = 02, Message = "Awesome recipe" });
            list.Add(new Comment() { AuthorId = 067, BlogId = 12, CommentDate = Convert.ToDateTime("6/5/2022"), CommentId = 01, Message = "Awesome! Loved this" });
            list.Add(new Comment() { AuthorId = 021, BlogId = 6, CommentDate = Convert.ToDateTime("12/3/2022"), CommentId = 05, Message = "Just made this for my family and they enjoyed it" });
            list.Add(new Comment() { AuthorId = 036, BlogId = 2, CommentDate = Convert.ToDateTime("4/27/2021"), CommentId = 04, Message = "Perfect for Christmas" });
            list.Add(new Comment() { AuthorId = 065, BlogId = 28, CommentDate = Convert.ToDateTime("2/21/2022"), CommentId = 03, Message = "I really liked it" });
            return list;
        }

        public static List<Comment> LoadComments_2()
        {
            List<Comment> list = new List<Comment>();

            list.Add(new Comment() { AuthorId = 068, BlogId = 12, CommentDate = Convert.ToDateTime("10/14/2021"), CommentId = 02, Message = "Awesome" });
            list.Add(new Comment() { AuthorId = 053, BlogId = 6, CommentDate = Convert.ToDateTime("9/5/2022"), CommentId = 01, Message = "Really loved this" });
            list.Add(new Comment() { AuthorId = 042, BlogId = 6, CommentDate = Convert.ToDateTime("12/4/2022"), CommentId = 05, Message = "Wow" });
            return list;
        }

        public static List<Blog> LoadBlogs()
        {
            List<Blog> list=new List<Blog>();
            list.Add(new Blog() { BlogCategory = "Breakfast", BlogDate = Convert.ToDateTime("4/14/2022"), BlogId = 12, BlogName = "Oatmeal Recipe" });
            list.Add(new Blog() { BlogCategory = "Dinner", BlogDate = Convert.ToDateTime("2/18/2022"), BlogId = 6, BlogName = "Lasagna Recipe" });
            list.Add(new Blog() { BlogCategory = "Lunch", BlogDate = Convert.ToDateTime("7/09/2022"), BlogId = 2, BlogName = "Sushi Bowl" });
            list.Add(new Blog() { BlogCategory = "Snacks", BlogDate = Convert.ToDateTime("3/27/2021"), BlogId = 28, BlogName = "Bounty Bars" });
            list.Add(new Blog() { BlogCategory = "Desserts", BlogDate = Convert.ToDateTime("9/12/2021"), BlogId = 18, BlogName = "Strawberry Cheesecake" });
            list.Add(new Blog() { BlogCategory = "Lunch", BlogDate = Convert.ToDateTime("7/08/2022"), BlogId = 3, BlogName = "Tuna Salad" });
            return list;
        }
    }
}
