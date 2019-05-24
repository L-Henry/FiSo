using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    enum Instructie { plus , min , deel, vermenigvuldig , macht , vierkantsworel , haakjeOpen, haakjeToe }

    class Program
    {
        public static double Bereken(Instructie inst, params double[] getallen)
        {
            switch (inst)
            {
                case Instructie.plus:
                    double som = 0;
                    for (int i = 0; i < getallen.Length; i++)
                    {
                        som += getallen[i];
                    }
                    return som;
                case Instructie.min:
                    double verschil = 0;
                    for (int i = 0; i < getallen.Length; i++)
                    {
                        verschil += getallen[i];
                    }
                    return verschil;
                case Instructie.deel:
                    double deling = 0;
                    for (int i = 0; i < getallen.Length; i++)
                    {
                        deling /= getallen[i];
                    }
                    return deling;
                case Instructie.vermenigvuldig:
                    double product = 0;
                    for (int i = 0; i < getallen.Length; i++)
                    {
                        product *= getallen[i];
                    }
                    return product;
                    /*
                case Instructie.macht:
                    return Math.Pow(getallen[0], getallen[1]);
                case Instructie.vierkantsworel:
                    if (getallen[0] == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return Math.Pow( getallen[0], 1 / getallen[1] );
                    }
                    */
                default:
                    return 0;
                    
            }
        }

        
        public static double Bereken(Instructie inst, double getal1, double getal2)
        {
            switch (inst)
            {
                case Instructie.plus:
                    return getal1 + getal2;
                case Instructie.min:
                    return getal1 - getal2;
                case Instructie.deel:
                    return getal1 / getal2;
                case Instructie.vermenigvuldig:
                    return getal1 * getal2;
                case Instructie.macht:
                    return Math.Pow(getal1, getal2);
                case Instructie.vierkantsworel:
                    if (getal1 == 0)
                    {
                        return 0;
                    }
                    else
                    {
                    return Math.Pow(getal1, 1 / getal2);
                    }
                default:
                    return 0;
            }
        }
        

        public static double[] InputVerwerken(params string[] getallen)
        {
            double[] getal = new double[getallen.Length];

            for (int i = 0; i < getal.Length; i++)
            {
                if (double.TryParse(getallen[i], out getal[i]))
                {
                    getal[i] = double.Parse(getallen[i]);
                }
                else
                {
                    Console.WriteLine("Geef geldig getal in.");
                    getallen[i] = Console.ReadLine();
                    return InputVerwerken(getallen);
                }
            }
            return getal;

        }

        static void Main(string[] args)
        {
            /*
            loop:
            Console.WriteLine("Geef 2 getallen in.");
            string[] getallen = Console.ReadLine().Split();

            int getal1;
            if (int.TryParse(getallen[0], out getal1))
            {
                getal1 = int.Parse(getallen[0]);
            }
            else
            {
                Console.WriteLine("Geef geldig getal in.");
            }

            int getal2;
            if (int.TryParse(getallen[1], out getal2))
            {
                getal2 = int.Parse(getallen[1]);
            }
            else
            {
                Console.WriteLine("Geef geldig getal in.");
            }
            */
            loop:
            Console.WriteLine("Geef getallen in.");
            string[] inputGetallen = Console.ReadLine().Split();
            double[] getal = InputVerwerken(inputGetallen);

            Console.WriteLine("Geef instructie in.");
            string teken = Console.ReadLine();
            Instructie inst = 0;
            string woord = "De Uitkomst";
            if (teken == "+")
            {
                inst = Instructie.plus;
                woord = "De som";

            }
            else if (teken == "-")
            {
                inst = Instructie.min;
                woord = "Het verschil";
            }
            else if (teken == "^")
            {
                inst = Instructie.macht;
                woord = "De macht";
            }
            else if (teken == "/")
            {
                inst = Instructie.deel;
                woord = "De deling";
            }
            else if (teken == "*")
            {
                inst = Instructie.vermenigvuldig;
                woord = "De vermenigvuldiging";
            }
            else if (teken == "sqrt")
            {
                inst = Instructie.vierkantsworel;
                woord = "De vierkantswortel";
            }
            else
            {
                Console.WriteLine("Geef een van volgende tekens in: + - / *");
            }

            string lijst = string.Join($" {teken} ", getal);
            Console.WriteLine($"{woord} van {lijst} = {Bereken(inst, getal)}");

            //Console.WriteLine($"{woord} van {getal[0]} {teken} {getal[1]} = {Bereken(inst, getal[0], getal[1])}");
            goto loop;

            Console.ReadLine();

        }
    }
}
