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
			Console.ReadLine();
		}
        
    }
}
