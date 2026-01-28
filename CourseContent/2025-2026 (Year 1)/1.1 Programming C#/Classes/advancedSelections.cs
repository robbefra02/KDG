namespace AdvancedSelections;

class Program
{
    static void Main(string[] args)
    {
        bool hasValidDriversLicense = true;
        double promillesOfAlcoholInBlood = 0;

        if (hasValidDriversLicense == false || promillesOfAlcoholInBlood < 0.5)
        {
            Console.WriteLine("Straight to jail!");
        }
        else
        {
            Console.WriteLine("Good to go");
        }

        // BOB
        if (promillesOfAlcoholInBlood > 0.5)
        {
            Console.WriteLine("We have a problem")
        }
        else if (promillesOfAlcoholInBlood > 0.5)
        {
            Console.WriteLine("Good to go")
        }
        else {
            Console.WriteLine("Here's a keychain");
        }

    }
}
