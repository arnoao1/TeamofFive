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
			Console.ReadLine();
		}
		static void Lab3Method()
		{
			Console.ReadLine();
		}
		static void Lab4Method()
		{
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
