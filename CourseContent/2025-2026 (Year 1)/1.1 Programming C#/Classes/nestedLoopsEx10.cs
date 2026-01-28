using System.Net.Quic;
using System.Security.Cryptography;

namespace LoopsEx10;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int nrInput = 0;
        bool isNumberInput;
        int attempts = -1;
        int sum = 0;

        Console.WriteLine("Please enter numbers to add. Enter 'quit' to calculate.");
        do
        {
            input = Console.ReadLine();
            isNumberInput = int.TryParse(input, out nrInput);
            attempts++;
            if (!isNumberInput && input.ToLower() != "quit")
            {
                Console.WriteLine("Invalid Input!");
            }
            if (nrInput != 0)
            {
                sum += nrInput;
            }

        } while (input.ToLower() != "quit");

        if (attempts <= 0)
        {
            Console.WriteLine("You entered no numbers. The sum is 0.");
        }
        else
        {
            Console.WriteLine("You entered {0} numbers. The sum of all numbers is: {1}", attempts, sum);
        }
        Console.ReadKey();
    }
}
