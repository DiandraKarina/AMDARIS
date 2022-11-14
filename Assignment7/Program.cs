using Assignment7;
using System;
using System.Collections;
using System.Linq;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> comments1=ListManager.LoadComments_1();
        foreach(var comment in comments1)
        {
            Console.WriteLine($"User with Id {comment.AuthorId} commented \"{comment.Message}\" [{comment.CommentId}], on {comment.CommentDate}");
        }

        //Ordering
        List<Comment> orderedcomments=ListManager.LoadComments_1();

        orderedcomments=orderedcomments.OrderBy(x => x.CommentDate).ToList();

        Console.WriteLine("Comments ordered by date:");

        foreach(var orderedcomment in orderedcomments)
        {
            Console.WriteLine($"User with Id {orderedcomment.AuthorId} commented \"{orderedcomment.Message}\" [{orderedcomment.CommentId}], on {orderedcomment.CommentDate}\"");
        }

        //Filtering
        List<Comment> filteredcomments = ListManager.LoadComments_1();

        filteredcomments = filteredcomments.Where(x => x.CommentDate.Year==2022).ToList();


        Console.WriteLine("Comments filtered by year:");

        foreach (var filteredcomment in filteredcomments)
        {
            Console.WriteLine($"User with Id {filteredcomment.AuthorId} commented \"{filteredcomment.Message}\" [{filteredcomment.CommentId}], on {filteredcomment.CommentDate}\"");
        }


        //Grouping

        List<Blog> blogs = ListManager.LoadBlogs();
        foreach (var blog in blogs)
        {
            Console.WriteLine($"The blogpost for {blog.BlogName} with Id {blog.BlogId} from category {blog.BlogCategory} was posted on {blog.BlogDate} ");
        }

        var GroupByCat = blogs.GroupBy(b => b.BlogCategory);

        foreach (var blog in GroupByCat)
        {
            foreach (var category in blog)
            {
                Console.WriteLine($"Category {category.BlogCategory}");
            }
        }
        
        //Aggregation

        int sum = comments1.Sum(x => x.AuthorId);
        Console.WriteLine(sum);

        

        List<User> users1 = new List<User>()
        {
            new User(){Id=1,Name="Ioana"},
            new User(){Id=2,Name="Andreea"},
            new User(){Id=3,Name="Floriana"},
            new User(){Id=4,Name="Maria"},
        };

        List<User> users2 = new List<User>()
        {
            new User(){Id=10,Name="Ioana"},
            new User(){Id=6,Name="Andreea"},
            new User(){Id=8,Name="Floriana"},
            new User(){Id=9,Name="Maria"},
        };

      
        //Set
        var result = users1.Intersect(users2, new UserNameComparer());

        Console.WriteLine("Common user names:");
        foreach (var item in result)
        {
            Console.WriteLine(item.Id + " " + item.Name);
        }

        //Quantifiers
        var getUser = new User { Name = "Maria" };
        var Check_Result = users1.Contains(getUser, new UserNameComparer());
        Console.WriteLine(Check_Result);


        //Generation methods
        IEnumerable<string> repeatStrings = Enumerable.Repeat("Test for repeat linq generation methods", 10);
        foreach (String str in repeatStrings)
        {
            Console.WriteLine(str);
        }


        //Element op
        string[] names = { "Tommy", "Adam", "Maria", "Gabriela", "Loredana" };
        Random random = new Random(DateTime.Now.Millisecond);
        string name = names.ElementAt(random.Next(0, names.Length));
        Console.WriteLine("The name chosen at random is '{0}'.", name);


      //Join and projection

        List<Comment> comments2 = ListManager.LoadComments_2();

        IEnumerable<Comment> sameBlog = from Comment inventoryCommentOne in comments1
                                         join Comment inventoryCommentTwo in comments2
                                         on inventoryCommentOne.BlogId
                                         equals inventoryCommentTwo.BlogId
                                         select inventoryCommentOne;

        OutputCollectionToConsole(sameBlog);

        
        Console.ReadKey();
    }

    private static void OutputCollectionToConsole(IEnumerable<object> collectionToOutput)
    {
        foreach (object collectionItem in collectionToOutput)
            Console.WriteLine(collectionItem.ToString());
    }

}