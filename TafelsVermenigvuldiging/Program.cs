using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafelsVermenigvuldiging
{
    class Program
    {

        public static int TafelsRecursief(int getal1, int getal2, int stopGetal)
        {
            if (getal1 == stopGetal)
            {
                Console.WriteLine($"{getal1} x {stopGetal} = {getal1 * stopGetal}");
                return stopGetal * stopGetal;
            }
            else if (getal2 < stopGetal)
            {
                Console.WriteLine($"{getal1} x {getal2} = {getal1 * getal2}");
                return TafelsRecursief(getal1, ++getal2, stopGetal);
            }
            else
            {
                Console.WriteLine($"{getal1} x {getal2} = {getal1 * getal2}");
                return TafelsRecursief(++getal1, 0, stopGetal);
            }
        }

        public static double Faculteit(int getal)
        {
            double resu = 1;
            while (getal > 0)
            {
                resu *= getal;
                getal--;
            }
            return resu;
            /*
            int stop = getal;
            if (getal == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i < stop; i++)
                {
                    getal *= i;
                }
                return getal;
            }
            */
        }

        public static double FaculteitRecursief(int getal)
        {
            if (getal == 1 || getal == 0)
            {
                return 1;
            }
            else
            {
                return getal * FaculteitRecursief(--getal);
            }
        }

        static void Main(string[] args)
        {
            
            /*
            loop:
            Console.WriteLine("Geef getal in");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"Faculteit van {input} = {Faculteit(input)} via for loop");
            Console.WriteLine($"Faculteit van {input} = {FaculteitRecursief(input)} via Recursief");
            goto loop;
            */

            
            loop:
            Console.WriteLine("Geef getal in:");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"Faculteiten van {input} = {Faculteit(input)} via for loop");
            for (int i = 0; i <= input; i++)
            {
                Console.WriteLine($"Faculteit van {i} = {Faculteit(i)}");
            }
            Console.WriteLine("");
            Console.WriteLine($"Faculteiten van {input} = {FaculteitRecursief(input)} via Recursief");
            for (int i = 0; i <= input; i++)
            {
                Console.WriteLine($"Faculteit van {i} = {FaculteitRecursief(i)}");
            }
            goto loop;
            

            /*
            //loop:
            int getal = int.Parse(Console.ReadLine());
            for (int i = 0; i <= getal; i++)
            {
                for (int j = 0; j <= getal; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
            //goto loop;

            //int getal = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Recursief:");
            TafelsRecursief(0, 0, getal);
            */

         

            /*
            Console.WriteLine("Geef getal in.");
            int get = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef in tot welke macht.");
            int macht = Convert.ToInt32(Console.ReadLine());
            double resu;
            for (int i = 0; i < macht+1; i++)
            {
                resu = Math.Pow(get,i);
                Console.WriteLine($"De {i}de macht van {get} = {resu}");
            }
            */




            Console.ReadLine();
;        }
        
    }
}
