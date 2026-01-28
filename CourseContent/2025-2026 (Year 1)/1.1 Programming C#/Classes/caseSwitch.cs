namespace DayOfWeek;

class Program
{
    static void Main(string[] args)
    {
        string dayOfWeek = Console.ReadLine();
        dayOfWeek = dayOfWeek.ToLower();
        switch (dayOfWeek.ToLower())
        {
            case "monday":
                Console.WriteLine("1");
                break;

            case "tuesday":
                Console.WriteLine("2");
                break;

            case "wednesday":
                Console.WriteLine("3");
                break;

            case "thursday":
                Console.WriteLine("4");
                break;

            case "friday":
                Console.WriteLine("5");
                break;

            case "saturday":
                Console.WriteLine("6");
                break;

            case "sunday":
                Console.WriteLine("7");
                break;

            default:
                Console.WriteLine("{0} is not a day of the week", dayOfWeek);
                break;
        }

        Console.ReadKey();
    }
}
