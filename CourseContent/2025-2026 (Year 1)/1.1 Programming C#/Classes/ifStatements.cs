namespace if_statements;

class Program
{
    static void Main(string[] args)
    {
        // declare variables
        int firstNumber = 8;
        int secondNumber = 8;

        // make an if statement
        if (firstNumber < secondNumber)
        {
            Console.WriteLine("The first number, {0}, is smaller than the second number, {1}", firstNumber, secondNumber);
        }
        else if (firstNumber > secondNumber)
        {
            Console.WriteLine("The first number, {0}, is bigger than the second number, {1}", firstNumber, secondNumber);
        }
        else Console.WriteLine("The first number, {0}, is equal to the second number, {1}", firstNumber, secondNumber);
        Console.ReadKey();
    }
}
