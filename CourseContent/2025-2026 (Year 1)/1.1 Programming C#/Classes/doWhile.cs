namespace Do_While_2;

class Program
{
    static void Main(string[] args)
    {
        int number;
        bool isValid;
        byte counter = 0;

        do
        {
            Console.WriteLine("Enter a number!");
            isValid = int.TryParse(Console.ReadLine(), out number);
            counter++;
        }
        while (!isValid);

        if (isValid)
        {
            Console.WriteLine("Thanks!");
        } else if (!isValid)
        {
            Console.WriteLine("You suck at numbers!");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
