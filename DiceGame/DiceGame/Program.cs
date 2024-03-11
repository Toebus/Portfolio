internal class Program
{
    private static void Main(string[] args)
    {

        int playerrandomnumber;
        int enemyrandomnumb;


        int playerpoints = 0;
        int enemypoints = 0;
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {

            Console.WriteLine("Press any key to roll the dice :)");

            Console.ReadKey();

            playerrandomnumber = random.Next(1, 7);
            Console.WriteLine("you rolled a: " + playerrandomnumber);

            Console.WriteLine("...");

            System.Threading.Thread.Sleep(1000);

            enemyrandomnumb = random.Next(1, 7);
            Console.WriteLine("Enemy Ai rolled a: " + enemyrandomnumb);

            if (playerrandomnumber > enemyrandomnumb)
            {
                playerpoints ++;
                Console.WriteLine("Player wins this round "+ i);
                Console.WriteLine("The player have: " + playerpoints + " Points");
            }

            if (enemyrandomnumb > playerrandomnumber)
            {
                enemypoints ++;
                Console.WriteLine("Enemy wins round " + i);
                Console.WriteLine("The enemy have: " + enemypoints + " Points");
            }
        }

        if (enemypoints > playerpoints)
        {
            int Leftover = enemypoints - playerpoints;
            Console.WriteLine("Enemy wins! with: "+ Leftover + " Points");
        }
        else if (playerpoints > enemypoints)
        {
            int Leftover = playerpoints - enemypoints;
            Console.WriteLine("player wins! with: " + Leftover + " Points");
        }
        else if (playerpoints == enemypoints)
        {
            
            Console.WriteLine("THIS WAS A DRAW!");

        }
        else { Console.WriteLine("Something went wrong!"); }

        Console.ReadKey(); // bare for at få programmet til at vente  :P 

    }
}