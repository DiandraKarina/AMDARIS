
using Strategy;

class Program
{
    static void Main(string[] args)
    {
        var context = new RecipeBoxContext();

        Console.WriteLine("Membership type has been set to keto:");
        context.SetStrategy(new KetoStrategy());
        context.MemberDietType();
        Console.WriteLine();

        Console.WriteLine("Membership type has been set to vegetarian:");
        context.SetStrategy(new VegetarianStrategy());
        context.MemberDietType();
        Console.WriteLine();

        Console.WriteLine("Membership type has been set to vegan:");
        context.SetStrategy(new VeganStrategy());
        context.MemberDietType();
    }
}