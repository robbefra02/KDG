using System.Runtime.InteropServices;

namespace Lesson_2;

class Program
{
    static void Main(string[] args)
    {
        string firstName;                                    // creating variable to store the name value
        int age;                                             // same for age value
        bool isValidAge;
        string ageString;
        Console.WriteLine("Please enter your name:");        // prompting user to enter their name
        firstName = Console.ReadLine();                      // assign the name to the var
        Console.WriteLine("Please enter your age:");         // same for age
        do
        {
            ageString = Console.ReadLine();
            isValidAge = int.TryParse(ageString, out age);
            if (!isValidAge)
            {
                Console.WriteLine("Please enter a number only.");
            }
        } while (!isValidAge);

        Console.Write("Your name is {0} and you are {1} years old", firstName, age);        // outputting the given name and age to the user
        Console.ReadKey();                                  // keeping the terminal open until a key is pressed
    }
}
