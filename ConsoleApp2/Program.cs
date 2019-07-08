using System;

namespace StringReverse
{
    public class Program
    {
    public TGetal[] Reverse<TGetal>(params TGetal[] getallen)
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
            int[] intTest = new int[] { 1, 2, 3 };
            string[] intString = new string[] { "1", "2", "3" };

            Console.WriteLine();

            

            public static T[] CreateArray<T>(int size)
            {
                return new T[size];
            }

            public static TGetal Som<TGetal>(params TGetal[] getallen) where TGetal : struct
            {

            }
    }
}

