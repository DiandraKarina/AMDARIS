using Singleton;

class Program
{
    static void Main(string[] args)
    {
        DataBase dataBase = DataBase.DataBaseInstance;
        dataBase.users.Add(new User { Id = 123, Name = "Mihaela" });
        Console.WriteLine("User added");
        
    }
}