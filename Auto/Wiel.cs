using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{


    class Wiel
    {
        public bool IsAanHetRonddraaien { get; private set; } = false;
        public int Inches { get; }

        public Wiel(int diameter)
        {
            Inches = diameter;
        }

        internal void DraaiRond()
        {
            IsAanHetRonddraaien = true;
        }

        internal void StopMetDraaien()
        {
            IsAanHetRonddraaien = false;
        }

        internal void Oppompen()
        {
            Console.WriteLine("Wiel wordt opgepompt.");
        }
    }
}
