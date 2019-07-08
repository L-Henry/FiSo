using System;

namespace Stringrev
{
    class Program
    {
        public static TGetal[] Reverse<TGetal>(params TGetal[] getallen)
        {
            TGetal[] temp = new TGetal[getallen.Length];
            for (int i = 0; i < getallen.Length; i++)
            {
                temp[i] = getallen[getallen.Length - 1 - i];
            }
            return temp;
        }


        static void Main(string[] args)
        {

            DynamischeLijst<int> lijst = new DynamischeLijst<int>();
            lijst.Add(1);
            lijst.Add(2);
            lijst.Add(3);

            DynamischeLijst<string> lijst2 = new DynamischeLijst<string>("een", "twee", "drie", "vier", "vijf");
            lijst2.Add(3, "3.3");

            Console.WriteLine(lijst.Count());
            Console.WriteLine(lijst2.Count());
            for (int i = 0; i < lijst.Count(); i++)
            {
                Console.Write(lijst.Get(i) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < lijst2.Count(); i++)
            {
                Console.Write(lijst2.Get(i) + " ");
            }
            Console.WriteLine();
            // REMOVE
            lijst.Remove(1);
            lijst2.Remove(3);
            Console.WriteLine(lijst.Count());
            Console.WriteLine(lijst2.Count());
            for (int i = 0; i < lijst.Count(); i++)
            {
                Console.Write(lijst.Get(i) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < lijst2.Count(); i++)
            {
                Console.Write(lijst2.Get(i) + " ");
            }


            /*   REVERSE
            lijst.Reverse();
            lijst2.Reverse();
            for (int i = 0; i < lijst.Count(); i++)
            {
                Console.Write(lijst.Get(i) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < lijst2.Count(); i++)
            {
                Console.Write(lijst2.Get(i) + " ");
            }
            Console.WriteLine();
            */



            /*
            int[] intTest = new int[] { 1, 2, 3 };
            string[] stringTest = new string[] { "1", "2", "3" };

            for (int i = 0; i < intTest.Length; i++)
            {
                Console.Write(Reverse(intTest)[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < stringTest.Length; i++)
            {
                Console.Write(Reverse(stringTest)[i] + " ");
            }
            */


            Console.ReadLine();

        }
    }
}
