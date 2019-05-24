using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schrikkerljaar
{
    class Program
    {
        public static bool IsSchrikkeljaar(int jaar)
        {
            /*
            if ( (jaar % 400 == 0) || ( (jaar % 4 == 0) && (jaar % 100 != 0) ) )
            {
                return true;
            }
            else
            {
                return false;
            }
            //bool uit = false;
            //return uit = ((jaar % 400 == 0) || ((jaar % 4 == 0) && (jaar % 100 != 0))) ? true : false;
            */
            return (jaar % 400 == 0) || ( (jaar % 4 == 0) && (jaar % 100 != 0) );
        }

        public static int GetAantalDagen(int jaar1, int jaar2)
        {
            int schrik = 0;
            for (int i = jaar1; i < jaar2; i++)
            {
                if ( IsSchrikkeljaar(i) )
                {
                    schrik++;
                }
            }
            return ( 365 * ( jaar2 - jaar1 ) +  schrik );
        }

        public static int GetAantalDagen(int jaar, int maand, int dag)
        {
            int[] maanden = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            maanden[1] = IsSchrikkeljaar(jaar) ? 29 : 28; //februari
            int dagenNa = dag;
            for (int i = 1; i < maand; i++)
            {
                dagenNa += maanden[i-1];
            }
            return dagenNa - 1;
        }

        public static int GetAantalDagen(int jaar1, int maand1, int dag1, int jaar2, int maand2, int dag2)
        {
            return GetAantalDagen(jaar1, jaar2) + GetAantalDagen(jaar2, maand2, dag2) - GetAantalDagen(jaar1, maand1, dag1);

            /*
            int[] maanden = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int dagen = 0;
            
            if (maand2 > maand1)
            {
                for (int i = maand1; i < maand2; i++)
                {
                    dagen += maanden[i-1];
                }
            }
            else if (maand2 < maand1)
            {
                for (int i = maand1; i > maand2; i--)
                {
                    dagen -= maanden[i-2];
                }
            }
            */
            /*
            if ( IsSchrikkeljaar(jaar1) && maand1 > 2 && ( maand2 <= 2 || jaar1 != jaar2 ) )
            {
                dagen--;
            }
            if ( IsSchrikkeljaar(jaar1) && IsSchrikkeljaar(jaar2) && maand1 <= 2 && maand2 > 2 )
            {
                dagen++;
            }
            if ( IsSchrikkeljaar(jaar2) && maand2 > 2 && jaar1 != jaar2 )
            {
                dagen++;
            }
            */

            //return GetAantalDagen(jaar1, jaar2) + dagenNa - dagenVoor + dagen;


        }

        public static string GetDag(int jaar, int maand, int dag)
        {
            int jaar1 = 1;
            int maand1 = 1;
            int dag1 = 1;
            //int aantal = 0;
            int aantal = GetAantalDagen(jaar1, maand1, dag1, jaar, maand, dag) % 7;
            
            if (GetAantalDagen(jaar1, maand1, dag1, jaar, maand, dag) >= 0)
            {
                aantal = GetAantalDagen(jaar1, maand1, dag1, jaar, maand, dag) % 7;
            }
            else
            {
                aantal = 7 - ( Math.Abs(GetAantalDagen(jaar1, maand1, dag1, jaar, maand, dag) ) % 7 );
            }
            
            //string[] dagen = new string[] { "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag", "Maandag", "Dinsdag" }; //van 1970
            string[] dagen = new string[] { "Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag" };
            return dagen[aantal];

        }
        static void Main(string[] args)
        {
            /*
            loop:
            Console.WriteLine("Geef jaartal in.");
            int jaar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{IsSchrikkeljaar(jaar)}");
            goto loop;
            */
            //Console.WriteLine($"{IsSchrikkeljaar(jaar)}");

            /*
            loop:
            Console.WriteLine("Geef eerste datum");
            string[] input = Console.ReadLine().Split();
            int dag1 = int.Parse(input[0]);
            int maand1 = int.Parse(input[1]);
            int jaar1 = int.Parse(input[2]);
            Console.WriteLine("Geef tweede datum");
            string[] input2 = Console.ReadLine().Split();
            int dag2 = int.Parse(input2[0]);
            int maand2 = int.Parse(input2[1]);
            int jaar2 = int.Parse(input2[2]);
            Console.WriteLine($"Aantal dagen tussen datum een en twee = {GetAantalDagen(jaar1, maand1, dag1, jaar2, maand2, dag2)}");
            Console.WriteLine($"Berekening is: {GetAantalDagen(jaar1, jaar2)} dagen tussen de jaren + {GetAantalDagen(jaar2, maand2, dag2)} dagen van tweede datum " +
                 $"- {GetAantalDagen(jaar1, maand1, dag1)} dagen van eerste datum die reeds voorbij waren.");    
             goto loop;
             */

            loop:
            Console.WriteLine("Geef eerste datum");
            string[] input = Console.ReadLine().Split();
            int dag1 = int.Parse(input[0]);
            int maand1 = int.Parse(input[1]);
            int jaar1 = int.Parse(input[2]);
            Console.WriteLine($"De dag is {GetDag(jaar1, maand1, dag1)}");
            goto loop;

            Console.ReadLine();
        }
    }
}
