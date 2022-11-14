using Assignment3_2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

//IEnumerable- interface that enables iterating over collections
//ICloneable-interface that allows objects to provide cloning support
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person(Person.Gender.Male, "Mihai", "Pop", new DateTime(1992, 06, 21));

        User user1 = new User(Person.Gender.Female, "Andreea", "Pop", new DateTime(1995, 07, 12));
        User user2 = user1.Clone() as User;
        User user3 = new User(Person.Gender.Female, "Maria", "Silaghi", new DateTime(1998, 03, 07));

        Admin admin = new Admin(Person.Gender.Female, "Diandra", "Gherman", new DateTime(2000, 01, 07));
        
        user1.Id = 12345;
        person.ViewBlog();
        user1.ViewBlog();
        user2.DeletePost();
        user3.DeletePost();
        admin.DeletePost(user1.Id);
        admin.ViewBlog();

        MealPrep mealprep = new MealPrep();

        foreach (Recipe recipe in mealprep)
        {
            if (recipe.DryIngredient=="normal flour")
            {
                recipe.IsGlutenfree("is not");
            }
            else
            {
                recipe.IsGlutenfree("is");
            }
        }



    }
}