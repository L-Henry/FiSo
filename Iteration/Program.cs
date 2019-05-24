using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    enum sorteerOpNeer { Niet, Op, Neer }

    class Program
    {

        public static int Som(params int[] getallen)
        {
            int resu = 0;
            foreach (int a in getallen)
            {
                resu += a;
            }
            return resu;
        }
        public static int KleinsteGetal(params int[] getallen)
        {
            int laagst = getallen[0];
            foreach (int a in getallen)
            {
                if (a < laagst)
                {
                    laagst = a;
                }
            }
            return laagst;
        }
        public static int GrootsteGetal(params int[] getallen)
        {
            int hoogst = getallen[0];
            foreach (int a in getallen)
            {
                if (a > hoogst)
                {
                    hoogst = a;
                }
            }
            return hoogst;
        }
        public static int Products(params int[] getallen)
        {
            int resu = 1;
            foreach (int a in getallen)
            {
                resu *= a;
            }
            return resu;
        }
        public static int[] Sorteer(sorteerOpNeer inst, params int[] getallen)
        {
            // kan ook met boolean ipv enumerate en boolean sorting = descending ? -1 : 1;
            switch (inst)
            {
                case sorteerOpNeer.Op:
                    for (int i = 0; i < getallen.Length; i++)
                    {
                        for (int j = i; j < getallen.Length; j++)
                        {
                            if (getallen[j] < getallen[i])
                            {
                                int vergelijk = getallen[i];
                                getallen[i] = getallen[j];
                                getallen[j] = vergelijk;
                            }
                        }
                    }
                    return getallen;

                case sorteerOpNeer.Neer:
                    for (int i = 0; i < getallen.Length; i++)
                    {
                        for (int j = i; j < getallen.Length; j++)
                        {
                            if (getallen[j] * -1 < getallen[i] * -1) // of gewoon > en < omdraaien, of met boolean sorting meegeven en *sorting ipv * -1 zoals SorteerBool
                            {
                                int vergelijk = getallen[i];
                                getallen[i] = getallen[j];
                                getallen[j] = vergelijk;
                            }
                        }
                    }
                    return getallen;
                default:
                    return getallen;
            }
        }

        public static int[] SorteerBool(bool descending, params int[] getallen)
        {
            //int vergelijk = 0; //getallen[getallen.Length - 1];
            int sorting = descending ? -1 : 1;
            for (int i = 0; i < getallen.Length; i++)
            {
                for (int j = i; j < getallen.Length; j++)
                {
                    if (getallen[j] * sorting < getallen[i] * sorting)
                    {
                        int vergelijk = getallen[i];
                        getallen[i] = getallen[j];
                        getallen[j] = vergelijk;
                    }
                }
            }
            return getallen;
        }

        public static int[] Omkeren(params int[] getallen)
        {
            int j = getallen.Length;
            for (int i = 0; i < j / 2; i++)
            {
                int vergelijk = getallen[i];
                getallen[i] = getallen[j - i - 1];
                getallen[j - i - 1] = vergelijk;
            }
            return getallen;
        }

        public static int[] OmkerenNieuw(params int[] getallen)
        {
            int[] nieuw = new int[getallen.Length];
            for (int i = 0; i < nieuw.Length; i++)
            {
                nieuw[i] = getallen[getallen.Length - i - 1];
            }
            return nieuw;
        }

        static void Main(string[] args)
        {
            //int[] getallen = new int[] { 2, 5, 3, 9, 10, 7, 8, 20, 1 };
            Console.WriteLine("Geef aantal getallen in");
            int aantal = Convert.ToInt32(Console.ReadLine());
            int[] getallen = new int[aantal];
            
            Console.WriteLine("Geef de getallen in");
        
            for (int i = 0; i < aantal; i++)
            {
                getallen[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine($"De som is {Som(getallen)}");
            Console.WriteLine($"Kleinste getal is {KleinsteGetal(getallen)}");
            Console.WriteLine($"Grootste getal is {GrootsteGetal(getallen)}");
            Console.WriteLine($"Product is {Products(getallen)}");
  
            //Console.WriteLine($"Omgekeerde lijst: {Omkeren(getallen)}");
            int[] omgekeerdeLijst = OmkerenNieuw(getallen);
            Console.WriteLine($"Omgekeerde lijst: {omgekeerdeLijst}");

            /*
            Console.WriteLine("Sorteer op of neer?");4
            sorteerOpNeer inst;
            string antwoord = Console.ReadLine().ToUpper();
            if (antwoord == "OP")
            {
                inst = sorteerOpNeer.Op;
            }
            else if (antwoord == "NEER")
            {
                inst = sorteerOpNeer.Neer;
            }
            else
            {
                inst = sorteerOpNeer.Niet;
            }
            */
            /*
            Console.WriteLine("Op (1) of neer (0)?");
            bool antwoord = Convert.ToBoolean(Console.ReadLine());
            bool descending = antwoord;
            Console.WriteLine($"Product is {SorteerBool(descending, getallen)}");
            */
            /*
            Console.WriteLine($"Product is {Sorteer(inst, getallen)}");
            */

            Console.WriteLine("Getallen:");
            Console.WriteLine("[{0}]", string.Join(", ", getallen));
            foreach (int a in getallen)
            {
                Console.WriteLine(a);

            }
            Console.WriteLine("Omgekeerde lijst");
            foreach (int a in omgekeerdeLijst)
            {
                Console.WriteLine(a);

            }






            /* 
            int i = 0;
            double loopNummer = 0;

            while (i < 100)
            {
                 loopNummer = Math.Pow(2,i);
                 Console.WriteLine(loopNummer);
                 i++;
            }
            */
            /*
            int[] getallen = new int[] { 1, 2, 3, 4, 5 };
            int teller = 0;

            while (teller < getallen.Length)
            {
                Console.WriteLine($"Mijn getal [{teller}]: {getallen[teller]}");
                teller++;
            }
            */

            /*
            Console.WriteLine("Welkom!");
            //Console.WriteLine("Wenst u nog eens verwelkomd te worden? (Y/N)");
            string antwoord = "";
            
            while (antwoord != "N")
            {
                Console.WriteLine("Wenst u nog eens verwelkomd te worden? (Y/N)");
                antwoord = Console.ReadLine();
                if (antwoord == "Y")
                {
                    Console.WriteLine("Welkom!");
                }
            }
            */

            /*
            do
            {
                Console.WriteLine("Welkom!");
                Console.WriteLine("Wenst u nog eens verwelkomd te worden? (Y/N)");
                antwoord = Console.ReadLine();
            } while (antwoord.ToUpper() == "Y");
            */

            /*
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Hello World!");
            }
            */

            /*
            for (int i = 0; i < 100; i++)
            {
                for (int teller = 0; teller < 100; teller++)
                {
                    Console.WriteLine($"Hello {teller + 100 * i}");
                }
            }
            */

            /*
            int a = 1;
            for (int i = 1; i < 10; i++)
            {
                a *= i;
                Console.WriteLine($"Faculteit van {i} = {a}");
            }
            */

            /*
            double aaa = 1;
            Console.WriteLine("Geef faculteit in");
            int facult = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < facult+1; i++)
            {
                aaa *= i;
                Console.WriteLine($"Faculteit van {i} = {aaa}");
            }
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

            /*
            int[] lijst = new int[] { 2, 5, 3, 9 };
            int resu = 1;
            foreach (int a in lijst)
            {
                resu *= a;
            }
            Console.WriteLine(resu);
            */










            /*
            int pri = 2;
            int get = Convert.ToInt32(Console.ReadLine());
            /hile (get % pri == 0)
            {
                if (get == pri)
                {
                    Console.WriteLine("Ja");
                }
                else
                {
                    Console.WriteLine("Neen");
                }
                pri++;
            }
            */
            /*
            int get = Convert.ToInt32(Console.ReadLine());
            for (int prie= 2; get % prie == 0; prie++)
            {
                if (get == prie)
                {
                    Console.WriteLine("Ja");
                }
                else
                {
                    Console.WriteLine("Neen");
                }
                prie++;
            }
            */

            Console.ReadLine();
        }
    }
}
