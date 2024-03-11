internal class Program
{
    private static void Main(string[] args)
    {
        bool Iscorrect = false;
        Random random = new Random();

        int randomnum = random.Next(1, 11);

        Console.WriteLine("Welcome to the number guessing game :D ");
        Console.WriteLine("A number between 1 and 10 will be generated");
        Console.WriteLine( "If you guess the correct number you win!" );

      

        while (!Iscorrect)
        {
            Console.WriteLine("Please enter you guess");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess > randomnum)
            { Console.WriteLine("you Guess is to High");
            }
            if (guess < randomnum)
            { Console.WriteLine("You guess is to low"); }

            if (guess == randomnum)
            {
                Console.WriteLine("Correct you win!!");
               
                Iscorrect = true;
            }
        }
        Console.WriteLine("The Correct number is: " + randomnum + " you won the game!");
        Console.ReadKey(); 

    }
}