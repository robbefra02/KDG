namespace NestedLoopsEx2;

class Program
{
    static void Main(string[] args)
    {
        int rows = 6;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.ReadKey();
    }
}
