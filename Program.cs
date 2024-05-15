namespace TeamofFive.usb
{
    internal class teamproject
    {
        static void Main(string[] args)
        {
            Lab6Method()
			
		}
		static void Lab6Method()
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
    }
}
