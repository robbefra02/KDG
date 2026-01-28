namespace Exercise8;

class Program
{
    static void Main(string[] args)
    {
        int input = NrInput(Console.ReadLine());
        
        CheckPrime(input);
        Console.ReadKey();
    }

    static void CheckPrime(int checkedNumber)
    {
        bool isPrime = true;
        for (int i = 2; i <= checkedNumber; i++)
        {
            if (checkedNumber % i == 0)
            {
                isPrime = false;
            }


        }
        if (isPrime)
        {
            Console.Write(" and it is a prime number", checkedNumber);
        }
        else if (!isPrime)
        {
            Console.Write(" and it is not a prime number", checkedNumber);
        }
    }

    static int NrInput(int input) {
        while (!int.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input! Please try again.");
        }
        return
    }
}