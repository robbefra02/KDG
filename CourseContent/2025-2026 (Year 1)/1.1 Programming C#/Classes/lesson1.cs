namespace Week1Number4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 3 keys, they will be returned in a reverse order");
        string FirstKey = Console.ReadLine();
        string SecondKey = Console.ReadLine();
        string ThirdKey = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("Here ya go!");
        Console.WriteLine("");
        Console.Write(ThirdKey);
        Console.Write(",");
        Console.Write(SecondKey);
        Console.Write(",");
        Console.Write(FirstKey);

        Console.WriteLine("");
        Console.WriteLine("Press any key to exit...");
        Console.WriteLine("");
        Console.ReadKey();
    }
}
