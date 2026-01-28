namespace selection_exercise_1;

class Program
{
    static void Main(string[] args)
    {
        // declare variables
        int firstNumber;
        int secondNumber;

        string userInput;

        bool isValidInput;

        bool canShowResult = true;

        // ask for first nr input
        Console.WriteLine("We're comparing numbers! YAAAAAAAY");
        Console.WriteLine("Please enter a number.");
        userInput = Console.ReadLine();
        isValidInput = int.TryParse(userInput, out firstNumber);
        if (!isValidInput) // if not valid
        {
            Console.WriteLine("Not valid input!");
            canShowResult = false;
        }

        // ask for second nr input
        userInput = Console.ReadLine();
        isValidInput = int.TryParse(userInput, out secondNumber);
        if (!isValidInput) // if not valid
        {
            Console.WriteLine("Not valid input!");
            canShowResult = false;
        }

        // compare and tell user
        if (canShowResult)
        {
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("The numbers are the same");
            }
            else
            {
                Console.WriteLine("The numbers are not the same");
            }
        }
        Console.ReadKey();
    }
}
