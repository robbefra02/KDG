using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Net.NetworkInformation;

namespace PrevExam;
/// <summary>
/// This code is written by Robbe Fransen in 2025.
/// The assignment was to ask the user for a 5-digit number input,
/// then convert that to morse code and calculate what the percentage of morse code used is.
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        // declaring vars
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int userInput = -1;
        string morseOutput;

        // asking for input
        userInput = AskInput(ref userInput);

        // converting input to morse
        morseOutput = ToMorse(userInput);

        Console.WriteLine("Press any key to exit..");
        Console.ReadKey();
    }
    static int AskInput(ref int userInput)
    {
        // declaring local variables
        bool numberInput;
        bool allowedNumber;

        // writing text to the console
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Welcome to the morse code converter!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Enter a number to be converted to morse code.\nOnly numbers between 0 and 99 999 are allowed:");

        // keep asking input until it's right
        do
        {
            numberInput = int.TryParse(Console.ReadLine(), out userInput); // reading console

            // if the nr is less than 100k and more than 0 it's allowed
            if (userInput >= 0 && userInput < 100000)
            {
                allowedNumber = true;
            }
            else allowedNumber = false;

            // if the input is not a number or not between the right values, punish the user
            if (!numberInput || !allowedNumber)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Only numbers between 0 and 99 999 are allowed!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        } while (!numberInput || !allowedNumber);

        return userInput;
    }

    static string ToMorse(int userInput)
    {
        string morseOutput = "nothin";

        // table to convert to morse
        List<string> morse = new List<string> { "-----", "•----", "••---", "•••--", "••••-", "•••••", "-••••", "--•••", "---••", "----•" };

        // table to contain the user input that's converted into morse
        List<int> digits = new List<int>();
        List<string> toMorse = new List<string>();
        List<int> charUsedList = new List<int>();
        int charsUsed = 0;

        // cut userInput into new list with every single integer
        while (userInput !=0)
        {
            digits.Add(userInput%10);
            userInput = userInput/10;
        }
        digits.Reverse();


        // convert to Morse in a new list toMorse
        for (int i = 0; i < digits.Count; i++)
        {
            toMorse.Add(morse[digits[i]]);
            // count charachters by adding them to another list, checking if the nr is in the list and if its not, adding one to charsUsed.
            if (!charUsedList.Contains(digits[i]))
            {
                charUsedList.Add(digits[i]);
                charsUsed++;
            }
        }

        // print output
        Console.WriteLine(Convert.ToString(string.Join(" ", toMorse)));
        Console.WriteLine("{0}% of characters were used", charsUsed * 10);
        
        // send the output back to the main functiondflape[fkjeoirwhgryvgnouwe]
        morseOutput = Convert.ToString(string.Join(" ", toMorse));
        return morseOutput;
    }

}
