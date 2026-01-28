using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace Loops_ex_3;

class Program
{
    static void Main(string[] args)
    {
        // declare variables
        int amountOfNumbers;
        int numberCounter = 1;
        bool isValid = true;

        int sum = 0;

        Console.WriteLine("How many numbers do you want to count?");
        do
        {
            if (!isValid)
            {
                Console.WriteLine("Wrong input! Please try again:");
            } else
            {
                Console.WriteLine("Enter a number!");
            }
            isValid = int.TryParse(Console.ReadLine(), out amountOfNumbers);
        }
        while (!isValid);

        Console.WriteLine("The first {0} amount numbers are:", amountOfNumbers);

        while (numberCounter <= amountOfNumbers)
        {
            Console.Write("{0} ", numberCounter);
            sum = sum + numberCounter;
            numberCounter++;
        }
        Console.WriteLine("\nThe sum of the natural numbers up to {0} is {1}", amountOfNumbers, sum);
        Console.WriteLine("Press any key to continue..");
        Console.ReadKey();
    }
}
