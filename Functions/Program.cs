using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Schrijf(string tekst)
        {
            Console.WriteLine(tekst);
            Console.WriteLine(tekst + " Bla");
        }
        static int TelOp(int getal1, int getal2)
        {
            return getal1 + getal2;
        }
        static int Optellen()
        {
            int getal1 = 5;
            int getal2 = 3;
            return getal1 + getal2;
        }
        static void Verdubbel(ref int getal)
        {
            getal *= 2;
            //getal += getal;
        }
        static int VerdubbelReturn(int getal)
        {
            //getal *= 2;
            //getal += getal;
            return getal *= 2;
        }
        static void VerdubbelOut(int getal, out int result)
         {
            result = getal * 2;
         }
        static int Som(params int[] getallen)
        {
            return getallen.Sum();
        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine($"Optellen geeft: {Optellen()}");

            Console.WriteLine("Geef getal 1 in: ");
            int get1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 2 in: ");
            int get2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"De som van {get1} en {get2} is: {TelOp(get1, get2)}");
            */
            int get1 = 5;
            int get2 = 3;
            Schrijf("TelOp geeft: " + TelOp(get1, get2));
            
            int getalRef = 5;
            Console.WriteLine($"Mijn getal met Verdubbel ref: {getalRef}");
            Verdubbel(ref getalRef);
            Console.WriteLine($"Mijn getal met Verdubbel ref: {getalRef}");
            
            int getalReturn = 15;
            Console.WriteLine($"Mijn getal met VerdubbelReturn: {getalReturn}");
            getalReturn = VerdubbelReturn(getalReturn);
            Console.WriteLine($"Mijn getal met VerdubbelReturn: {getalReturn}");
            
            int getalOut = 25;
            int result;
            VerdubbelOut(getalOut, out result);
            Console.WriteLine($"Mijn getal met VerdubbelOut: {getalOut}");
            Console.WriteLine($"Mijn getal met VerdubbelOut: {result}");

            Console.WriteLine("");
            Console.WriteLine("Iets anders");
            int testGetal = 12;
            ref int ttGet = ref testGetal;
            testGetal *= 2;
            Console.WriteLine($"testgetal: {testGetal}");
            Console.WriteLine($"ttGet: {ttGet}");

            Console.WriteLine("");
            int[] getallen = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Som van getallen is: {Som(getallen)}");
            Console.WriteLine($"Som van 1, 2, 3, 4, 5 met params is: { Som(1, 2, 3, 4, 5) }");


            Console.ReadLine();
        }

        
    }
}
