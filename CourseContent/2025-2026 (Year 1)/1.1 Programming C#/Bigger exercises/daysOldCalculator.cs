using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Exercise3;

class Program
{
    static void Main(string[] args)
    {
        // defining variables
        string[] birthdayInput;
        int birthDay;
        int birthMonth;
        int birthYear;

        string[] currentDate;
        int currentDay;
        int currentMonth;
        int currentYear;

        int totalDays = 0;

        int firstDays = 0;
        int birthYearCompletion = 0;
        int roundYears = 0;
        int finalMonths = 0;

        // asking user for their birth date
        Console.WriteLine("Enter your birthday in dd/mm/yyyy format:");
        // checking if input is valid
        birthdayInput = DateInput();
        birthDay = int.Parse(birthdayInput[0]);
        birthMonth = int.Parse(birthdayInput[1]);
        birthYear = int.Parse(birthdayInput[2]);

        // asking user for the date to day
        Console.WriteLine("Enter the current day in dd/mm/yyyy format:");

        // checking if input is valid
        currentDate = DateInput();
        currentDay = int.Parse(currentDate[0]);
        currentMonth = int.Parse(currentDate[1]);
        currentYear = int.Parse(currentDate[2]);

        // calculate days from birthday until the end of that year
        firstDays += (DaysInMonth(birthMonth, birthYear) - birthDay);

        for (int i = birthMonth + 1; i <= 12; i++)
        {
            birthYearCompletion += DaysInMonth(i, birthYear);
        }


        // calculate days between full years birth - today
        for (int i = birthYear + 1; i < currentYear; i++)
        {
            if (IsLeapYear(i))
            {
                roundYears += 366;
            }
            else roundYears += 365;
        }

        //calculate the remainder of days in actual year
        for (int i = 1; i < currentMonth; i++)
        {
            finalMonths += DaysInMonth(i, currentYear);
        }

        // sum up all of the days
        totalDays = firstDays + birthYearCompletion + roundYears + finalMonths + (currentDay);

        Console.WriteLine("You are {0} days old", totalDays);
        Console.ReadKey();
    }


    static string[] DateInput()
    {
        string input;
        string[] array;

        int day = -1;
        int month = -1;
        int year = -1;

        bool correctInput = false;
        bool correctDay = false;
        bool correctMonth = false;
        bool correctYear = false;

        do
        {
            input = Console.ReadLine();
            array = input.Split('/');
            if (array.Count() != 3)
            {
                correctInput = false;
            }
            else if (array.Count() == 3)
            {
                correctInput = true;
                int.TryParse(array[0], out day);
                int.TryParse(array[1], out month);
                int.TryParse(array[2], out year);
                if (day > 0 && day <= 31)
                {
                    correctDay = true;
                }
                else correctDay = false;
                if (month > 0 && month <= 12)
                {
                    correctMonth = true;
                }
                else correctMonth = false;
                if (year <= 2025)
                {
                    correctYear = true;
                }
                else correctYear = false;
            }
            if (!correctInput || !correctDay || !correctMonth || !correctYear)
            {
                Console.WriteLine("Incorrect input! Please try again:");
            }
        } while (!correctInput || !correctDay || !correctMonth || !correctYear);
        return array;
    }

    static bool IsLeapYear(int year)
    {
        bool leapYear;
        if (year % 4 == 0)
        {
            leapYear = true;
        }
        else leapYear = false;
        return leapYear;
    }

    static int DaysInMonth(int month, int year)
    {
        int nrOfDays = -1;
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                nrOfDays = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                nrOfDays = 30;
                break;
            case 2:
                if (IsLeapYear(year))
                {
                    nrOfDays = 29;
                }
                else nrOfDays = 28;
                break;
        }

        return nrOfDays;
    }
}

