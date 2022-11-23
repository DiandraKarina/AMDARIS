using Domain.Models;
using Domain.Models.Enums;
using System;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        WriteLine("How many users do you want to create?");
        string x = ReadLine();
        int count = Int32.Parse(x);

        for (var i = 0; i <= count - 1; i++)
        {
            WriteLine("Enter user data:");

            WriteLine("Enter first name:");
            string FirstName = ReadLine();

            WriteLine("Enter last name:");
            string LastName = ReadLine();

            WriteLine("Enter id:");
            string id = ReadLine();
            int Id = Int32.Parse(id);

            WriteLine("Enter gender:");
            string gender = ReadLine();
            Gender EnumValue;
            Gender.TryParse(gender, out EnumValue);

            User user1 = new User(FirstName, LastName, Id, EnumValue, new DateTime(1990, 02, 10));
            WriteLine($"A new account has been created for user {FirstName} {LastName}");

            List<Category> categories = new List<Category>();
            WriteLine("Enter the number of categories you want for your blog:");

            string x2 = ReadLine();
            int count2 = Int32.Parse(x2);

            WriteLine("Enter the name of the categories:");
            for (var i2 = 0; i2 <= count2 - 1; i2++)
            {
                categories.Add(new Category());
                categories[i2].Name = ReadLine();
            }
            WriteLine("The user introduced in her blog the categories:");
            foreach (Category category in categories)
            {
                WriteLine(category.getData());
            }

            WriteLine("Creating the blog...");
            Blog blog1 = new Blog(001, user1.Id, categories);
        }


        List<Comment> comments = new List<Comment>();
        comments.Add(new Comment());
        BlogPost post1 = new BlogPost();
        BlogPost post2 = new BlogPost();

        WriteLine("Create blogpost for user1:");
        WriteLine("Name of blogpost:");
        post1.PostName = ReadLine();
        WriteLine("Name of category:");
        post1.CategoryName = ReadLine();

        WriteLine("Create blogpost for user2:");
        WriteLine("Name of blogpost:");
        post2.PostName = ReadLine();
        WriteLine("Name of category:");
        post2.CategoryName = ReadLine();

        PostRating rating = new PostRating();

        WriteLine("Press 3 if user 1 wants to add comment to blogpost of user 2\n" +
                  "Press 4 if user 2 wants to add comment to blogpost of user 1");

        int Selection = int.Parse(Console.ReadLine());

        switch (Selection)
        {
            case 3:
                {
                    WriteLine("Write comment:");
                    comments[0].Message = ReadLine();
                    comments[0].CommentId = 01;
                    post1.AddComment(comments[0]);
                    WriteLine($"User1 commented{comments[0].Message} to blogpost2");

                }
                break;

            case 4:
                {
                    WriteLine("Write comment:");
                    comments[0].Message = ReadLine();
                    comments[0].CommentId = 02;
                    post2.AddComment(comments[0]);
                    WriteLine($"User2 commented{comments[0].Message} to blogpost1");

                }
                break;

        }

        WriteLine("Press 5 if you want to delete comment 1\n" +
                  "Press 6 if you want to delete comment 2");


        int Selection2 = int.Parse(Console.ReadLine());

        switch (Selection2)
        {
            case 5:

                post1.RemoveComment(comments[0]);

                break;
            case 6:

                post2.RemoveComment(comments[0]);

                break;
        }

        WriteLine("Press 7 if you want to rate post1\n" +
                  "Press 8 if you want to rate post2");

        int Selection3 = int.Parse(Console.ReadLine());

        switch (Selection3)
        {
            case 7:
                {
                    WriteLine("Enter the number of stars (from 1 to 5)");
                    string r = ReadLine();
                    rating.Stars = Int32.Parse(r);
                    post1.AddRating(rating);
                    WriteLine($"You rated post \"{post1.PostName}\" with {rating.Stars} stars");
                }
                break;
            case 8:
                {
                    WriteLine("Enter the number of stars (from 1 to 5)");
                    string r = ReadLine();
                    rating.Stars = Int32.Parse(r);
                    post2.AddRating(rating);
                    WriteLine($"You rated post \"{post2.PostName}\" with {rating.Stars} stars");
                }
                break;
        }
    }
}


