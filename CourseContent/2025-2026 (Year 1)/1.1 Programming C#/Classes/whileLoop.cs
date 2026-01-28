namespace While_Loop;

class Program
{
    static void Main(string[] args)
    {
        // declaring variables
        int x = 1;
        int y = 5;

        while (x < y)
        {
            Console.WriteLine("My first variable {0} is smaller than the second one {1}", x, y);
            x++;
        }

        Console.WriteLine("Now they're not");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
