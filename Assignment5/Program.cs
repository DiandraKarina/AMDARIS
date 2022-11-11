using Assignment5;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    { 
        // try-catch-finally
         try
         {
            SearchRecipe(null);
         }
         catch (RecipeNotFoundException)
         {
            Console.WriteLine("Exception ocurred,recipe not found");
         }

         catch (Exception)
         {
            Console.WriteLine("An error occurred");
         }

         finally
         {
            Console.WriteLine("Finally block");
         }


        //rethrow exception
        Recipe recipe2 = new Recipe("oil", "butter");
        try
        {
            recipe2.show();
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("I caught rethrow exception");
        }


        //conditional compilation
        #if RELEASE
                Console.WriteLine("Release mode");
        #endif
        Console.WriteLine("Debug mode");

        //debug class
        Debug.WriteLine("Exiting Main");

    }

         //throw custom exception
         static void SearchRecipe(Recipe recipe)
            {
                if (recipe == null)
                {
                    throw new RecipeNotFoundException();
                }
            }

}