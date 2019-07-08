using System;
using System.Linq;

namespace Delegates
{
    class Program
    {
        public static bool GroterDanNul(int getal)
        {
            return getal > 0;
        }
        public static bool IsEven(int getal)
        {
            return getal % 2 == 0;
        }
        public static bool IsNegatief(int getal)
        {
            return getal < 0;
        }
        public static bool GroterDan100(int getal)
        {
            return getal > 0;
        }

        public static void MethodeMet2Parameters(string text, int getal)
        {
            ;
        }

        public static void SayHello()
        {
            Console.WriteLine("Say Hello");
        }

        //public delegate void MetString(string text);
        //public delegate bool Validatie(int getal);

        static void Main(string[] args)
        {
            Action doeIets = () => Console.WriteLine("Zeg hallo");
            doeIets += SayHello;
            doeIets();
            doeIets -= SayHello;
            doeIets();
            Console.WriteLine("------");

            
            //MetString metStringMethode = ZegGoeiemorgen;
            Action<string> metStringMethode = ZegGoeiemorgen;

            Action<string, int> meerdereParameters = MethodeMet2Parameters;

            var datum = DateTime.Now;
            if (datum.Hour > 8 && datum.Hour < 12)
            {
                metStringMethode = ZegGoeiemorgen;
            }
            else if (datum.Hour >= 12 && datum.Hour <= 18)
            {
                metStringMethode = ZegGoeiemiddag;
            }
            else if (datum.Hour > 18 && datum.Hour <= 22)
            {
                metStringMethode = ZegGoeienavond;
            }
            else
            {
                metStringMethode = delegate (string naam) { Console.WriteLine("Geoeienacht"); };
            }
            metStringMethode("Kenny");


            //Validatie vergelijk;
            //vergelijk = GroterDan100;
            //Console.WriteLine(vergelijk(101));

            int getal = 200;
            if (IsEven(getal) && GroterDan100(getal))
            {
                Console.WriteLine("Ja");
            }

            if (IsValid(getal, IsEven, GroterDan100))
            {
                Console.WriteLine("Ja met IsValid");
            }


            Console.ReadLine();
        }
        public static bool IsValid(int getal, params Func<int,bool>[] validaties)
        {
            var resultaat = true;
            validaties.All(validatie => validatie(getal) == true);

            /*
            foreach (var validatie in validaties)
            {
                if (!validatie(getal))
                {
                    resultaat = false;
                    break;
                }
            }
            */

            return resultaat;
        }

        public static void ZegGoeiemorgen(string naam)
        {
            Console.WriteLine($"Goeiemorgen {naam}!");
        }
        public static void ZegGoeiemiddag(string naam)
        {
            Console.WriteLine($"Goeiemiddag {naam}!");
        }
        public static void ZegGoeienavond(string naam)
        {
            Console.WriteLine($"Goeienavond {naam}!");
        }



    }
}
