namespace DiceRollApp;

class Program
{
    static void Main(string[] args)
    {
        int playerRollNum;
        int compRollNum;

        int playerNoWins = 0;
        int compNoWins = 0;
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Press any key to roll the dice");
            Console.ReadKey();

            playerRollNum = random.Next(1, 7);
            Console.WriteLine("The number you rolled is: " + playerRollNum);
            
            System.Threading.Thread.Sleep(2000);
            
            compRollNum = random.Next(1, 7);
            Console.WriteLine("The computer scored: " + compRollNum);

            if (playerRollNum > compRollNum)
            {
                Console.WriteLine("Player wins this round");
                playerNoWins++;
            }
            else if (compRollNum > playerRollNum)
            {
                Console.WriteLine("Computer wins");
                compNoWins++;
            }
            else
            {
                Console.WriteLine("It was a draw, no points added to either computer or the player");
            }
        }
         
        Console.WriteLine();
         
        if (playerNoWins > compNoWins)
        {
            Console.WriteLine($"Player wins over the comp with player scoring {playerNoWins - compNoWins} over the computer");
        }
        else if (compNoWins > playerNoWins)
        {
            Console.WriteLine($"Computer wins over with a lead of {compNoWins - playerNoWins} points");
        }
        else
        {
            Console.WriteLine("The game was a draw");
        }
        
        Console.ReadKey();
    }
}