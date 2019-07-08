using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myStringLijst = new List<string>(100);
            myStringLijst.Add("een");
            myStringLijst.Add("twee");
            myStringLijst.Add("drie");

            Console.WriteLine($"Lengte van lijst is {myStringLijst.Count}.");
            Console.WriteLine($"Capacity van lijst is {myStringLijst.Capacity}.");

            List<string> extraLijst = new List<string>();
            for (int i = 3; i < 100; i++)
            {
                extraLijst.Add(i.ToString());
            }
            myStringLijst.AddRange(extraLijst);
            
            string[] testString = myStringLijst.ToArray(); 
            myStringLijst.AddRange(testString);
            
            myStringLijst.Add("100ste plaats");

            Console.WriteLine($"Lengte van lijst is {myStringLijst.Count}.");
            Console.WriteLine($"Capacity van lijst is {myStringLijst.Capacity}.");

            Console.WriteLine($"Op de 100ste plaats staat {myStringLijst[100]}");

            myStringLijst.Remove("drie");
            Console.WriteLine($"Lengte van lijst is {myStringLijst.Count}.");
            Console.WriteLine($"Capacity van lijst is {myStringLijst.Capacity}.");

            for (int i = 0; i < myStringLijst.Count; i++)
            {
                Console.WriteLine(myStringLijst[i]);
            }











            Console.ReadLine();
        }
    }
}
