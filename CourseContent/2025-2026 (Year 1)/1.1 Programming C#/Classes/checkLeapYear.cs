namespace CheckLeapYear;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        int convertedInput;

        Console.WriteLine("Enter a year to check for a leap:");
        int.TryParse(Console.ReadLine(), out convertedInput);

        if (convertedInput % 4 == 0)
        {
            if (convertedInput % 100 == 0 && convertedInput % 400 != 0)
            {
                Console.WriteLine("This is not a leap year");
            }
            else
            {
                Console.WriteLine("This is a leap year");
            }
        }
        else
        {
            Console.WriteLine("This is not a leap year");
        }

        Console.ReadKey();
    }
}
