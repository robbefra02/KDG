namespace Exercise2;

class Program
{
    static void Main(string[] args)
    {
        int nrOfElements;
        int input;
        bool correctInput;
        List<int> numbers = new List<int>();

        // ask user input
        Console.WriteLine("How many numbers ya want?");
        do
        {
            correctInput = int.TryParse(Console.ReadLine(), out nrOfElements);
            if (!correctInput) //check if its a number
            {
                Console.WriteLine("Invalid input! Please try again:");
            }
        } while (!correctInput); // as long as it's not a number, repeat

        // ask values to fill in the list
        for (int i = 0; i < nrOfElements; i++)
        {
            Console.WriteLine("Enter nr {0}", i + 1);
            do
            {
                correctInput = int.TryParse(Console.ReadLine(), out input);
                if (!correctInput)
                {
                    Console.WriteLine("Invalid input for nr {0}! Please try again:", i + 1);
                }
            } while (!correctInput);
            numbers.Add(input);
        }

        /* OR:
            while(numbers.Count < nbrOfElements)
                {
                correctInput = int.TryParse(Console.ReadLine(), out input);
                if (CorrectInput)
                    {
                    numbers.Add(input);
                    }
                else if (!CorrectInput)
                    {
                    Console.WriteLine("Invalid Input!");
                    }
                }
        */

        Console.Write("\nThe numbers in the list are: ");
        for (int i = 0; i < nrOfElements; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }

        // could also use numbers.Reverse();
        Console.Write("\nThe numbers in reverse are: ");
        for (int i = nrOfElements - 1; i >= 0; i--)
        {
            Console.Write("{0} ", numbers[i]);
        }
        Console.ReadKey();
    }
}
