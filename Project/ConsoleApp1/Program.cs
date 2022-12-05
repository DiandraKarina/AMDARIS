using Domain.Models;
using Domain.Models.Enums;
using System;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        //create user
        User user1 = new User("Diandra", "Gherman", 01, Gender.Female);

        //create blog
        Blog blog1 = new Blog(001, user1.Id);

        //create a list of categories
        List<Category> categories = new List<Category>();
        Category category0 = new Category(0, "Breakfast");
        Category category1 = new Category(1, "Dinner");
        Category category2 = new Category(2, "Dessert");
        Category category3 = new Category(3, "Lunch");

        //create list of blogposts for blog
        List<BlogPost> blogPosts = new List<BlogPost>();
        blogPosts.Add(new BlogPost());
        blogPosts[0].PostName = "Banana pancakes";
        blogPosts[0].Category = category0;
        blogPosts.Add(new BlogPost());
        blogPosts[1].PostName = "Sweet Potato Salad";
        blogPosts[1].Category = category1;


        //add blogposts to blog
        blog1.AddBlogPost(blogPosts[0]);
        blog1.AddBlogPost(blogPosts[1]);


        //list of comments for post 1
        List<Comment> comments1 = new List<Comment>();

        //list of ratings for post 1
        List<PostRating> ratings1 = new List<PostRating>();

        //list of comments for post 2
        List<Comment> comments2 = new List<Comment>();

        //list of ratings for post 2
        List<PostRating> ratings2 = new List<PostRating>();

        //list of blog ratings
        List<BlogRating> blogRating = new List<BlogRating>();

        WriteLine($"Press 1 to leave a comment on post 1 {blogPosts[0].PostName}\n" +
                $"Press 2 to leave a comment on post 2 {blogPosts[1].PostName}");

        int selection = int.Parse(ReadLine());

        switch (selection)
        {

            case 1:
                {
                    comments1.Add(new Comment());
                    WriteLine("Write comment 1:");
                    comments1[0].Message = ReadLine();
                    blogPosts[0].AddComment(comments1[0]);
                    comments1.Add(new Comment());
                    WriteLine("Write comment 2:");
                    comments1[1].Message = ReadLine();
                    blogPosts[0].AddComment(comments1[1]);
                    WriteLine($"\"{blogPosts[0].PostName}\" has 2 comments:  \"{comments1[0].Message}\" and  \"{comments1[1].Message}\" ");
                }
                WriteLine("Press 1 to add ratings \n" +
                    "Press 2 to delete comments");
                int selection2 = int.Parse(ReadLine());
                switch (selection2)
                {

                    case 1:
                        {
                            ratings1.Add(new PostRating());
                            WriteLine("Enter the number of stars");
                            string R = ReadLine();
                            ratings1[0].Stars = Int32.Parse(R);
                            blogPosts[0].AddRating(ratings1[0]);
                            ratings1.Add(new PostRating());
                            WriteLine("Enter the number of stars");
                            string R1 = ReadLine();
                            ratings1[1].Stars = Int32.Parse(R1);
                            blogPosts[0].AddRating(ratings1[1]);
                            WriteLine($"This post was rated with {ratings1[0].Stars} and {ratings1[1].Stars} stars.");
                            WriteLine($"Average rating for post {blogPosts[0].PostName} : {blogPosts[0].AverageRating(ratings1)}\n");
                            break;
                        }

                    case 2:
                        {
                            WriteLine("Press 1 to delete comment 1. Press 2 to delete comment 2");
                            int selectionx = int.Parse(ReadLine());

                            switch (selectionx)
                            {
                                case 1:
                                    {
                                        blogPosts[0].RemoveComment(0);
                                        WriteLine("Comment 1 was deleted");
                                        break;
                                    }
                                case 2:
                                    blogPosts[0].RemoveComment(1);
                                    WriteLine("Comment 2 was deleted");
                                    break;
                            }
                            break;
                        }
                }
                WriteLine($"Comments on post {blogPosts[0].PostName}");

                foreach (var comment1 in comments1)
                {
                    WriteLine(comment1.Message);
                }
                break;



            case 2:
                {
                    comments2.Add(new Comment());
                    WriteLine("Write comment:");
                    comments2[0].Message = ReadLine();
                    blogPosts[1].AddComment(comments2[0]);
                    comments2.Add(new Comment());
                    WriteLine("Write comment:");
                    comments2[1].Message = ReadLine();
                    blogPosts[1].AddComment(comments2[1]);
                    WriteLine($"\"{blogPosts[1].PostName}\" has 2 comments:  \"{comments2[0].Message}\" and  \"{comments2[1].Message}\" ");

                    WriteLine("Press 1 to add ratings \n" +
                        "Press 2 to delete comments");
                    int selection3 = int.Parse(ReadLine());

                    switch (selection3)
                    {

                        case 1:
                            ratings2.Add(new PostRating());
                            WriteLine("Enter the number of stars");
                            string R2 = ReadLine();
                            ratings2[0].Stars = Int32.Parse(R2);
                            blogPosts[1].AddRating(ratings2[0]);
                            WriteLine("Enter the number of stars");
                            string R3 = ReadLine();
                            ratings2[1].Stars = Int32.Parse(R3);
                            blogPosts[1].AddRating(ratings2[1]);
                            WriteLine($"This post was rated with {ratings2[0].Stars} and {ratings2[1].Stars} stars.");
                            WriteLine($"Average rating for post {blogPosts[1].PostName} : {blogPosts[1].AverageRating(ratings2)}\n");
                            break;


                        case 2:
                            WriteLine("Press 1 to delete comment 1. Press 2 to delete comment 2");
                            int selectiony = int.Parse(ReadLine());
                            switch (selectiony)
                            {
                                case 1:
                                    blogPosts[1].RemoveComment(0);
                                    WriteLine("Comment 1 was deleted");
                                    break;

                                case 2:

                                    blogPosts[1].RemoveComment(1);
                                    WriteLine("Comment 2 was deleted");
                                    break;

                            }
                            break;
                    }
                    WriteLine($"Comments on post {blogPosts[1].PostName}");

                    foreach (var comment2 in comments2)
                    {
                        WriteLine(comment2.Message);
                    }

                    break;
                }

        }

        WriteLine("Add ratings for the blog");

        blogRating.Add(new BlogRating());
        string R4 = ReadLine();
        blogRating[0].Stars = Int32.Parse(R4);
        blog1.AddRating(blogRating[0]);
        blogRating.Add(new BlogRating());
        string R5 = ReadLine();
        blogRating[1].Stars = Int32.Parse(R5);
        blog1.AddRating(blogRating[1]);


        WriteLine($"Average rating for blog: {blog1.AverageRating(blogRating)}");




        /*
                            case 2:

                        switch (selection2)
                        {

                            case 1:
                                WriteLine("Write comment:");
                                comments[0].Message = ReadLine();
                                blogPosts1[0].AddComment(comments[0]);
                                WriteLine($"User1 commented \" {comments[0].Message}\" to post \"{blogPosts1[0].PostName}\"");
                                break;


                            case 2:
                                string R = ReadLine();
                                ratings[0].Stars = Int32.Parse(R);
                                blogPosts1[0].AddRating(ratings[0]);

                                break;

                            case 3:
                                WriteLine("Write comment:");
                                comments[1].Message = ReadLine();
                                blogPosts1[1].AddComment(comments[1]);
                                WriteLine($"User1 commented \"{comments[1].Message}\" to \"{blogPosts1[1].PostName}\"");
                                break;

                            case 4:
                                string R2 = ReadLine();
                                ratings[1].Stars = Int32.Parse(R2);
                                blogPosts1[1].AddRating(ratings[1]);
                                break;
                        }


                        break;

                }


                */

        /* switch (selection)
         {
             case 1:

                 switch (selection)
                 {
                     WriteLine("Write comment:");
                 comments[0].Message = ReadLine();
                 comments[0].CommentId = 01;
                 post1.AddComment(comments[0]);
                 WriteLine($"User1 commented{comments[0].Message} to blogpost2");
                 break;

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
        */

        /*

        Category category1 = new Category();
        category1.Name = "Breakfast";
        category1.CategoryId = 1;
        post1.Categories.Add(category1);

        Category category2 = new Category();
        category2.Name = "Dessert";
        category2.CategoryId = 2;
        post1.Categories.Add(category2);
        */

        /*List<BlogRating> ratings=new List<BlogRating>();
        ratings.Add(new BlogRating());
        string R = ReadLine();
        ratings[0].Stars = Int32.Parse(R);
        ratings.Add(new BlogRating());
        string R2 = ReadLine();
        ratings[1].Stars = Int32.Parse(R2);
        ratings.Add(new BlogRating());
        string R3 = ReadLine();
        ratings[2].Stars = Int32.Parse(R3);

         double AverageRating(List<BlogRating> blogRatings)
        {
            double avg = blogRatings.Average(a => a.Stars);
            return avg;
        }
        var x=AverageRating(ratings);
        WriteLine(x);
        */
        /* WriteLine("How many users do you want to create?");
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

             User user1 = new User(FirstName, LastName, Id, EnumValue);

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
                 WriteLine(category.GetData());
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

         int selection = int.Parse(Console.ReadLine());


         switch (selection)
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


         int selection2 = int.Parse(Console.ReadLine());

         switch (selection2)
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
        */
    }
}


