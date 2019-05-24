using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int myCounter = 10;
            string myText = Console.ReadLine();
            double pi = 3.1415;
            pi = 3.14159265359;

            Console.WriteLine(myCounter);
            Console.WriteLine(myText);
            Console.WriteLine(pi);
            Console.WriteLine("Geef pi in. 3,14159265359");
            pi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(pi);

            Console.ReadLine();
            */
            int[] enkel = new int[5] { 1,2,3,4,5 };
            enkel[1] = enkel[1] + 1;
            enkel[1] += 1;
            enkel[1]++;
            long enkelSom = enkel.Sum();
            Console.WriteLine($"2de waarde is {enkel[1]} en de som van de array is {enkelSom}.");
            Console.ReadLine();
        }
    }
}
