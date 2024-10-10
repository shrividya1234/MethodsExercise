namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 to read and write the code with WriteLine and ReadLine.
            Console.WriteLine("What is your name ?");
            var name = Console.ReadLine(); 
            Console.WriteLine("Favorite Color ?");
            var color = Console.ReadLine();
            Console.WriteLine("Favorite Animal ? ");
            var animal = Console.ReadLine();
            Console.WriteLine("Favoriate Band?");
            var band = Console.ReadLine();
            Console.WriteLine($"Name:{name} || Favorite Color : {color} || Favorite Animal : {animal} || Favorite Band : {band}" );
        }
    }
}
