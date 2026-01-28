namespace Exam22_23;

class Program
{
    static void Main(string[] args)
    {
        // declaring variables
        string firstName = "Robbe";
        string lastName = "Fransen";
        string fullName = firstName + " " + lastName;

        string menuChoice;
        bool isNumberInput;

        int nrOfStairs;
        int nrOfRows;

        double numerator;
        double denominator;
        double divisionResult;

        int startingIndex;
        int cuttingLength;
        string namePartToKeep;

        // ask user what to do
        do
        {
            // output menu
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("What would you like to do?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Draw Stairs");
            Console.WriteLine("- Divide");
            Console.WriteLine("- Name part");
            Console.WriteLine("- Quit");

            // ask user for input
            menuChoice = Console.ReadLine();
            menuChoice = menuChoice.ToLower();
            switch (menuChoice)
            {
                case "draw stairs":
                    Console.WriteLine("How many stairs do you want?");
                    do
                    {
                        isNumberInput = int.TryParse(Console.ReadLine(), out nrOfStairs);
                        if (!isNumberInput)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input a number:");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (!isNumberInput);
                    for (int i = 1; i <= nrOfStairs; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j == i - 1)
                            {
                                Console.Write("+");
                            }
                            else
                            {
                                Console.Write("-");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Press any key to restart..");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "divide":

                    // ask for numerator
                    Console.WriteLine("Enter a numerator:");
                    do
                    {
                        isNumberInput = double.TryParse(Console.ReadLine(), out numerator);
                        if (!isNumberInput)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input a number:");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (!isNumberInput);

                    // ask for denominator
                    Console.WriteLine("Enter a denominator:");
                    do
                    {
                        isNumberInput = double.TryParse(Console.ReadLine(), out denominator);
                        if (!isNumberInput)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input a number:");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (!isNumberInput);

                    // print result to user
                    if (denominator == 0)
                    {
                        Console.WriteLine("You are not allowed to divide by 0");
                    }
                    else
                    {
                        divisionResult = numerator / denominator;
                        Console.WriteLine("The result of the division is {0}", divisionResult);
                    }

                    // keep console open until key input
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Press any key to restart..");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "name part":
                    // asking an index to start cutoff
                    Console.WriteLine("Enter a starting index:");
                    do
                    {
                        isNumberInput = int.TryParse(Console.ReadLine(), out startingIndex);
                        if (!isNumberInput)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input a number:");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (!isNumberInput);

                    // asking length to cut away
                    Console.WriteLine("Enter the length to keep");
                    do
                    {
                        isNumberInput = int.TryParse(Console.ReadLine(), out cuttingLength);
                        if (!isNumberInput)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input a number:");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (!isNumberInput);

                    // cutting name up
                    namePartToKeep = fullName.Substring(startingIndex, cuttingLength);

                    // output result
                    Console.WriteLine(namePartToKeep);

                    // keep console open until key input
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Press any key to restart..");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();

                    break;
                case "quit":
                    break;
                default:
                    // report wrong command
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Unknown command!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        } while (menuChoice != "quit");
    }
}
