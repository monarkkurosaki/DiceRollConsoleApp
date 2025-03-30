namespace DiceRollApp;

class Program
{
    static void Main(string[] args)
    {
        int playerRollNum;

        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Press any key to roll the dice");
            Console.ReadKey();
            
            playerRollNum = random.Next(1, 7);
            
            Console.WriteLine("The number you rolled is: " + playerRollNum);
        }

        Console.ReadKey();
    }
}