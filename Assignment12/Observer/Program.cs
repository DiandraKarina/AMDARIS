


using Observer;

class Program
{
  static void Main(string[] args)
    {
        var blog = new Blog();

        var user1 = new User("Marian", "Covaci");
        var user2 = new User("Daniel", "Danea");

        blog.AddUser(user1);
        blog.AddUser(user2);

        blog.Post(new BlogPost("breakfast", DateTime.Now, 12, "Avocado on Toast"));
    }
}