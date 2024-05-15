using System.Threading;
using System;

namespace TeamofFive.usb
{
    internal class teamproject
    {
        static void Main(string[] args)
        {
            Lab1Method()
			Lab2Method()
			Lab3Method()
			Lab4Method()
			Lab5Method()
		}
		static void Lab1Method()
		{
			int Team1 = 0;
            int Team2 = 0;

            Random rand = new Random();
            Team1 = rand.Next(10);
            Team2 = rand.Next(10);
            Console.WriteLine("Lets see how your favorite team played today");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine($"(Team1 scored {Team1}) - (Team2 (your favorite team) scored {Team2})");
            Console.WriteLine();
            if (Team1 != Team2)
            {
                if (Team1 > Team2)
                {
                    Console.WriteLine("Your Team Lost!");
                }
                else 
                {
                    Console.WriteLine("Your Team Wins!");
                }
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            Thread.Sleep(10000);
		}
		static void Lab2Method()
		{
			int totalhours = 1;
			Console.WriteLine("Please Input a Number (Input 387)");
			totalhours = Convert.ToInt32(Console.ReadLine());
			int days = totalhours / 24;
			int hours = totalhours % 24;
			Console.WriteLine($"Your total hours is {totalhours}. You have {days} days, and you have {hours} hours.");
			Console.ReadLine();
		}
		static void Lab3Method()
		{
            int h, computer;
            char user, coin;
            string temp;
            Console.WriteLine("Heads or Tails");
            Console.WriteLine(" ");
            Console.WriteLine("h for heads or t for tails");
            temp = Console.ReadLine();
            user = Convert.ToChar(temp);
            Random random = new Random();
            Thread.Sleep(200);
            computer = random.Next(2);
            if (computer == 0)
            {
                Console.WriteLine(" \nThe answer is heads");
                coin = 'h';
            }
            else
            {
                Console.WriteLine(" \nThe answer is tails");
                coin = 't';
            }
            if (user == coin)
            {
                Console.WriteLine(" \nYAY, you won!");
            }
            else
            {
                Console.WriteLine(" \nYou lose :(");
            }
            Console.WriteLine($"You wrote {user}, the answer was {coin}");
            Console.ReadLine();
            Console.ReadLine();
        }
		static void Lab4Method()
		{
			    double miles, kilometers;
            string temp;
            const double MILES_FACTOR = 1.609344;
            Console.Write("How many miles would you like to be converted to kilometers?");
            temp = Console.ReadLine();
            miles = Convert.ToDouble(temp);
            kilometers = miles * MILES_FACTOR;
            Console.WriteLine($"The conversion of the distance in miles you have entered to kilometers is {kilometers:F2}" );
            Console.ReadLine();
		}
		static void Lab5Method()
		{
			string temp;
            char player, computer = '\0';
            int rock, paper, scissors;
            int comp;
            Random rand = new Random();

            Console.WriteLine("Lets play Rock paper Scissors");
            Thread.Sleep(1000);
            Console.WriteLine("Please choose between rock, paper, scissors");
            temp = Console.ReadLine();
            player = Convert.ToChar(temp);

            comp = rand.Next(3);

            switch (comp)
            {
                case 0:
                    computer = 'R';
                    break;
                case 1:
                    computer = 'P';
                    break;
                case 2:
                    computer = 'S';
                    break;
            }

            if (((player == 'R') && (computer == 'S')) || ((player == 'S') && (computer == 'P')) || ((player == 'P') && (computer == 'R')))
            {
                Console.WriteLine("Player won");

            }
            else if (player == computer)
            {
                Console.WriteLine("Its a Draw");
            }
            else
            {
                Console.WriteLine("Computer won");
            }
            Console.ReadLine();
		}
        
    }
}
