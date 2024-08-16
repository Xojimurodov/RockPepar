class Program
{

    static void Main()
    {
        int rock = 1;
        int scissort = 2;
        int paper = 3;
        Console.WriteLine("Welcome to game RockPaper");
        Console.WriteLine("Using: rock, scissort, paper");

        string text = Console.ReadLine() !;
        
        Random rnd = new Random();
        int value = rnd.Next(1, 3);

        switch(text)
        {
            case "rock": 
            if(value == 1)
            {
                Console.WriteLine("DRAW");
            }
            else if(value == 2)
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("You Lose");
            }
            break;

            case "scrissort":
            if(value == 1)
            {
                Console.WriteLine("You Lose");
            }
            else if(value == 2)
            {
                Console.WriteLine("Draw");
            }
            else
            {
                Console.WriteLine("You Win");
            }
            break;

            case "paper":
            if(value == 1)
            {
                Console.WriteLine("You Win");
            }
            else if(value == 2)
            {
                Console.WriteLine("You Lose");
            }
            else
            {
                Console.WriteLine("Draw");
            }
            break;

            default:
            Console.WriteLine("Error");
            break;
            
        }
    }
}
