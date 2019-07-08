using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Spel
    {
        public Stack<Schijf>[] HetSpel { get; set; }
        public Schijf Groot { get; set; }
        public Schijf Midden { get; set; }
        public Schijf Klein { get; set; }


        public Spel(int grootte)
        {
            HetSpel = new Stack<Schijf>[grootte];
            Groot = new Schijf(3);
            Midden = new Schijf(2);
            Klein = new Schijf(1);
            HetSpel[0] = new Stack<Schijf>(3);
            HetSpel[1] = new Stack<Schijf>(3);
            HetSpel[2] = new Stack<Schijf>(3);
            HetSpel[0].Push(Groot);
            HetSpel[0].Push(Midden);
            HetSpel[0].Push(Klein);
        }

        public void Print()
        {
            for (int i = 0; i < HetSpel.Length; i++)
            {
                if (HetSpel[i].Contains(Groot))
                {
                    Console.Write(Groot.Grootte);
                }
                if (HetSpel[i].Contains(Midden))
                {
                    Console.Write(Midden.Grootte);
                }
                if (HetSpel[i].Contains(Klein))
                {
                    Console.Write(Klein.Grootte);
                }
                Console.WriteLine();
            }
        }
    }
}
