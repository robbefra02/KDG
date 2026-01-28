using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BrickSelector;

/// <summary>
/// This code was written by Robbe Fransen in 2025.
/// It opens a console window with a tile grid where you can move around in.
/// The edges are basically mirrors, entering one side will move you to the opposite one.
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        int rows = 10;
        int columns = 15;
        List<ConsoleColor> color = new List<ConsoleColor>;

        bool stop = false;

        int locX = 0;
        int locY = 0;
        int prevLocX = 1;
        int prevLocY = 1;

        int tileNumber = 1;

        Dictionary<(int X, int Y), Tile> tiles = new Dictionary<(int X, int Y), Tile>();

        Console.Title = "Robbe's sh*t file";

        // print out the map
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        for (int x = 1; x <= rows; x++)
        {
            for (int y = 1; y <= columns; y++)
            {
                if (x == 1 && y == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Write("x");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    TileBrush(ConsoleColor.DarkGray);
                }
                (int locX, int locY) targetLocation = (x, y); // make ID for tile item
                Tile newTile = new Tile(ConsoleColor.DarkGray, false, x, y); // create a new Tile
                tiles.Add(targetLocation, newTile); // add tile to dictionary
                tileNumber++;
            }
            Console.WriteLine();
        }

        Console.WriteLine("screen built with {0} tiles!", tiles.Count());

        // movement detection
        do
        {
            // get previous locaiton
            prevLocX = locX;
            prevLocY = locY;

            // check input
            ConsoleKeyInfo keyInput = Console.ReadKey();
            switch (keyInput.Key)
            {
                case ConsoleKey.RightArrow:
                    if (locX == columns - 1)
                    {
                        locX = 0;
                    }
                    else
                    {
                        locX++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (locX == 0)
                    {
                        locX = columns - 1;
                    }
                    else
                    {
                        locX--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (locY == rows - 1)
                    {
                        locY = 0;
                    }
                    else
                    {
                        locY++;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (locY == 0)
                    {
                        locY = rows - 1;
                    }
                    else
                    {
                        locY--;
                    }
                    break;
                case ConsoleKey.Escape:
                    stop = true;
                    break;
                case ConsoleKey.Enter:
                    // Define the specific location you want
                    (int TargetX, int TargetY) targetLocation = (locX, locY);

                    // Safely try to retrieve the tile using the location as the key
                    if (tiles.TryGetValue(targetLocation, out Tile foundTile))
                    {
                        Console.SetCursorPosition(0, columns + 2);
                        Console.WriteLine($"Success! Retrieved Tile at ({targetLocation.TargetX}, {targetLocation.TargetY})");
                        Console.WriteLine($"Tile properties:\nColor: {foundTile.color}\nLocation: {foundTile.location}\nDeadly: {foundTile.meansDeath}");
                    }
                    else
                    {
                        Console.SetCursorPosition(columns + 2, 0);
                        Console.WriteLine($"Error: No Tile found at location ({targetLocation.TargetX}, {targetLocation.TargetY})");
                    }
                    break;
            }

                    // set previous location to grey
                    Console.SetCursorPosition(prevLocX, prevLocY);
                    TileBrush(ConsoleColor.DarkGray);

                    // set current location to mark X in blue
                    Console.SetCursorPosition(locX, locY);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Write("x");
                    Console.BackgroundColor = ConsoleColor.Black;
            } while (!stop) ; // continue until esc key is pressed

            // when stopped give byebye message
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Thanks for playing!\nPress any key to close this window...");
            Console.ReadKey();
        }
    
    static void TileBrush(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

    public class Tile
    {
        public ConsoleColor color;
        public bool meansDeath;
        public (int TargetX, int TargetY) location;
        public Tile(ConsoleColor color, bool meansDeath, int locX, int locY)
        {
            this.color = color;
            this.meansDeath = meansDeath;
            this.location = (locX, locY);
        }
}