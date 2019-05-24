using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_in_grid
{

    enum Richting { Links, Rechts, Op, Neer, Quit }

    class Program
    {
        public static int[] VindLocatie(ref int[,] grid)
        {
            int dim1 = grid.GetLength(0);
            int dim2 = grid.GetLength(1);
            int x = 0;
            int y = 0;
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        x = i;
                        y = j;
                    }
                }
            }

            int[] locatie = new int[2];
            locatie[0] = x;
            locatie[1] = y;
            //Console.WriteLine($"Locatie is {locatie[0] + 1} {locatie[1] + 1}");

            return locatie;
        }

        public static void PrintGrid(ref int[,] grid)
        {
            //int dim1 = grid.GetLength(0);
            //Console.Clear();
            int dim2 = grid.GetLength(1);
            int aantal = 0;
            
            foreach (int item in grid)
            {
                Console.Write("|");
                if (item == 1)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(" ");
                }
                aantal++;
                if (aantal == dim2)
                {
                    aantal = 0;
                    Console.WriteLine();
                }
            }
            int[] locatie = VindLocatie(ref grid);
            Console.WriteLine($"Locatie is {locatie[0] + 1} {locatie[1] + 1}");

        }

        public static void Beweeg(Richting richting, ref int[,] grid)
        {
            int[] locatie = VindLocatie(ref grid);
            int x = locatie[0];
            int y = locatie[1];
            switch (richting)
            {
                case Richting.Quit:
                    Console.ReadLine();
                    break;
                case Richting.Links:
                    try
                    { 
                        grid[x, y--] = 1;
                        grid[x, y] = 0;
                        PrintGrid(ref grid);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Kan niet naar links ,geef andere richting in.");
                    }
                    break;
                case Richting.Rechts:
                    try
                    {
                        if ( y == ( grid.GetLength(1) - 2) )
                        {
                            Console.WriteLine("Kan niet naar rechts ,geef andere richting in.");
                        }
                        else
                        {
                            grid[x, y++] = 1;
                            grid[x, y] = 0;
                            PrintGrid(ref grid);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Kan niet naar rechts ,geef andere richting in.");
                    }
                    break;
                case Richting.Op:
                    try
                    {
                        grid[x--, y] = 1;
                        grid[x, y] = 0;
                        PrintGrid(ref grid);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Kan niet naar boven ,geef andere richting in.");
                    }
                    break;
                case Richting.Neer:
                    try
                    {
                        grid[x++, y] = 1;
                        grid[x, y] = 0;
                        PrintGrid(ref grid);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Kan niet naar beneden ,geef andere richting in.");
                    }
                    break;
                default:
                    break;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Geef dimensies in.");
            string[] dimensiesInput = Console.ReadLine().Split();
            int dim1 = int.Parse(dimensiesInput[0]);
            int dim2 = int.Parse(dimensiesInput[1]);
            int[,] grid = new int[dim1, dim2 + 1];

            Console.WriteLine("Geef coordinates in");
            string[] coordinaten = Console.ReadLine().Split();
            int x = int.Parse(coordinaten[0]);
            int y = int.Parse(coordinaten[1]);
            grid[x - 1, y - 1] = 1;
            //grid[0, 0] = 1;
            PrintGrid(ref grid);


            //Richting richting = 0;
            //Console.WriteLine("Geef richting in");
            loop:
            Richting richting = 0;
            Console.WriteLine("Geef richting in");
            var r = Console.ReadKey(true);
            if (r.Key == ConsoleKey.NumPad8)
            {
                richting = Richting.Op;
            }
            else if (r.Key == ConsoleKey.NumPad2)
            {
                richting = Richting.Neer;
            }
            else if (r.Key == ConsoleKey.NumPad4)
            {
                richting = Richting.Links;
            }
            else if (r.Key == ConsoleKey.NumPad6)
            {
                richting = Richting.Rechts;
            }
            else if (r.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                //richting = Richting.Quit;
            }
            else
            {
                Console.WriteLine("Geef coordinates in");
                string[] coordinatenNieuw = Console.ReadLine().Split();
                int x2 = int.Parse(coordinaten[0]);
                int y2 = int.Parse(coordinaten[1]);
                grid[x2 - 1, y2 - 1] = 1; Console.WriteLine("Geef goed commando in.");
            }
            Beweeg(richting, ref grid);
            goto loop;


            //FindLocation(0, 0);

            Console.ReadLine();
        }
    }
}
