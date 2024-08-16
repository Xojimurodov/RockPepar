class Program
{

    public static void Main()
    {
        int rock = 1;
        int scissort = 2;
        int paper = 3;
        Console.WriteLine("Welcome to game RockPaper");
        Console.WriteLine("Using: Rock, scissort, paper");

        string text = Console.ReadLine() !;
        
        Random rnd = new Random();
        int value = rnd.Next(1, 3);
        
    }
}
