namespace Prompting_user_for_number_input;

class Program
{
    static void Main(string[] args)
    {
        // declaring variables
        int number;

        //asking user for input
        Console.WriteLine("Hey there! Give me a number:");

        //if NOT parsable, prompt for input again
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input! Please try again:");
        }
        
        // if it is parsable, write the value to int 'number' and display output to user
        Console.WriteLine("The number you have entered is {0}", number);
        Console.ReadKey();
    }
}
