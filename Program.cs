using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds;
            do
            {
                Console.WriteLine("How many rounds would you like to pLay? ");
                rounds = Convert.ToInt32(Console.ReadLine());
                if (rounds <= 10 && rounds >= 1)
                {
                    PlayGame(rounds);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 10");
                }
            }
            while (true);
            /*
            Console.WriteLine("How many rounds would you like to pLay? ");
            rounds = Convert.ToInt32(Console.ReadLine());
            if (rounds <= 10 && rounds >= 1)
            {
                PlayGame(rounds);
            }
            else
            {
                throw new Exception("Please enter a number between 1 and 10. ");
            }
            */
        }
        
        public static void PlayGame(int rounds)
        {
            for (int i = 0; i < rounds; i++)
            {
                int userchoice;
                int userwins = 0;
                int pcwins = 0;
                int ties = 0;

                Random random = new Random();

                Console.WriteLine("Please enter 1 for Rock, 2 for Paper or 3 for Scissors");
                userchoice = Convert.ToInt32(Console.ReadLine());

                // User plays Rock, Paper, Scissors
                if (userchoice <= 3 && userchoice >= 1)
                {
                    int pcchoice = random.Next(1, 4);

                    if (userchoice == pcchoice)
                    {
                        Console.WriteLine("This round is a tie");
                        //having problems adding this up
                        ties += 1;
                    }
                    else if ((userchoice == 1 && pcchoice == 3) || (userchoice == 2 && pcchoice == 1) || (userchoice == 3 && pcchoice == 2))
                    {
                        Console.WriteLine("User wins this round");
                        //having problems adding this up
                        userwins += 1;
                    }
                    else
                    {
                        Console.WriteLine("PC wins this round");
                        //having problems adding this up
                        pcwins += 1;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 3");

                }

                if (userchoice == i)
                {
                    //Show user results and exit to PlayAgain to ask user to play again
                    if (userwins > pcwins)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("User Wins!");
                        Console.WriteLine("User Won: " + userwins);
                        Console.WriteLine("PC Won: " + pcwins);
                        Console.WriteLine("Ties: " + ties);
                        Console.WriteLine("");
                        Console.WriteLine("Thanks for playing!!");
                        Console.WriteLine("");
                        PlayAgain();

                    }
                    else if (pcwins > userwins)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("PC Wins!");
                        Console.WriteLine("User Won: " + userwins);
                        Console.WriteLine("PC Won: " + pcwins);
                        Console.WriteLine("Ties: " + ties);
                        Console.WriteLine("");
                        Console.WriteLine("Thanks for playing!!");
                        Console.WriteLine("");
                        PlayAgain();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("It was a Tie!");
                        Console.WriteLine("User Won: " + userwins);
                        Console.WriteLine("PC Won: " + pcwins);
                        Console.WriteLine("Ties: " + ties);
                        Console.WriteLine("");
                        Console.WriteLine("Thanks for playing!!");
                        Console.WriteLine("");
                        PlayAgain();
                    }
                }

            }
            
        }

        public static void PlayAgain()
        {
            int selection;
            do
            {
                Console.WriteLine("Play again?  If so, enter how many rounds you would like to play.");
                selection = Convert.ToInt32(Console.ReadLine());
                if (selection == 1)
                {
                    //how to call the main method?
                    Main(null);
                }
                else
                {
                    Console.WriteLine("Please enter 1 to play again or 2 to exit");
                    break;
                }
            }
            while (true);
        }
    }
}
