using System.Linq.Expressions;

namespace IsNumberOddOrEven;

class Program
{
    static void Main(string[] args)
    {
        // define variables
        int number;
        int calculatedNumber;
        int moduloNumber;
        string userInput;
        bool isValidInput;

        // prompting user to enter a number
        Console.WriteLine("Enter the number you'd like to check");
        userInput = Console.ReadLine();
        isValidInput = int.TryParse(userInput, out number);

        // checking for valid input
        if (isValidInput)
        {
            // when input valid, calculate modulo
            moduloNumber = number % 2;
            if (moduloNumber == 0)
            {
                Console.WriteLine("It is even!");
            }
            else
            {
                Console.WriteLine("It is odd!");
            }
        }
        // if input not valid, shit on the user
        else
        {
            Console.WriteLine("I SAID NUMBER!");
        }

        Console.ReadKey();
            
    }
}
