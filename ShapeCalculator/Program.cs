internal class Program
{
    private static void Main(string[] args)
    {
        string answer;
        float result = 0;
        Console.WriteLine("What shape would you like to find the area of? please enter 'r' for Rectangle or 'c' for circle");

        answer = Console.ReadLine();

        if (answer == "r") 
        {
            Console.WriteLine("Please enter the height of the Rectangle ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please ennter the width of the Rectangle");
            float width = float.Parse(Console.ReadLine());
            result = height * width;

        }
        else if (answer == "c")
        {
            Console.WriteLine("Please enter the radius of the circle");
            float radius = float.Parse(Console.ReadLine());
            result = (float)Math.PI * (radius * radius);

        }
        else { Console.WriteLine("Please enter 'r' for Rectangle or 'c' for circle");
        }

        Console.WriteLine("The result is: " + result);

        Console.ReadKey();
    }
}