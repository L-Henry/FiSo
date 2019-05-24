using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] arr1;
            arr1 = new int[] { 0, 1, 2, 3, 4 };
            double[] arrd;
            arrd = new double[5];

            Console.WriteLine("index[0]: " + arr1[0]);
            Console.WriteLine("index[1]: " + arr1[1]);
            Console.WriteLine("index[2]: " + arr1[2]);
            Console.WriteLine("index[3]: " + arr1[3]);
            Console.WriteLine("index[4]: " + arr1[4]);
            */

            int[,] tabel = new int[3,4];
            tabel[0, 0] = 10;
            tabel[0, 1] = 20;
            tabel[1, 1] = 21;
            tabel[1, 2] = 31;
            Console.WriteLine("tabel[0,0]: " + tabel[0,0]);

            int[,] tabel2 = new int[2, 2] { {1,2},{1,2} };
            Console.WriteLine("tabel2[0,0]: " + tabel2[0, 0]);
            Console.WriteLine("Lente tabel2: " + tabel2.Length);

            int[][] jagged = new int[3][];
            jagged[0] = new int[1] { 10 };
            jagged[1] = new int[2] { 20, 30 };
            jagged[2] = new int[3] { 40, 50, 60 };
            Console.WriteLine("jagged: " + jagged[1][1]);
            Console.WriteLine("Lengte jagged: " + jagged.Length);
            Console.WriteLine("Lengte jagged[0]: " + jagged[0].Length);
            Console.WriteLine("Lengte jagged[1]: " + jagged[1].Length);
            Console.WriteLine("Lengte jagged[2]: " + jagged[2].Length);

            Console.WriteLine("String array");
            string[] enkelvoudigeArr = new string[5] { "a1", "b2", "c3", "d4", "e5" };
            Console.WriteLine("Index 3, 4de waarde: " + enkelvoudigeArr[3]);
            Console.WriteLine("Index 3, 4de waarde is: {0}", enkelvoudigeArr[3]);
            Console.WriteLine("Lengte enkelvoudigeArr: " + enkelvoudigeArr.Length);
            Console.WriteLine("Concatonate: {0}{1}{2} ", enkelvoudigeArr[0], enkelvoudigeArr[2], enkelvoudigeArr[4]);
            Console.WriteLine($"Concatonate: {enkelvoudigeArr[0]}{enkelvoudigeArr[2]}{enkelvoudigeArr[4]}"); //string interpolation

            Console.WriteLine("Som van int array");
            int[] enkelvoudigeArrNum = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Index 3, 4de waarde: " + enkelvoudigeArrNum[3]);
            Console.WriteLine("Index 3, 4de waarde is: {0}", enkelvoudigeArrNum[3]);
            Console.WriteLine("Lengte enkelvoudigeArrNum: " + enkelvoudigeArrNum.Length);
            Console.WriteLine("Som enkelvoudigeArrNum: " + enkelvoudigeArrNum.Sum());
            Console.WriteLine($"Concatonate: {enkelvoudigeArrNum[0]} {enkelvoudigeArrNum[3] + enkelvoudigeArrNum[4]} {enkelvoudigeArrNum[4]}"); //string interpolation

            Console.ReadLine();
        }
    }
}
