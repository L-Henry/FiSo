using System;
using System.Collections.Generic;
using System.Text;

namespace Static_vliegtuig
{
    public class Vliegtuig
    {
        public int Brandstof { get; set; }
        public int MaxBrandstof { get; set; }

        public static int AantalVliegtuigenInDeLucht { get; set; }
        public static int AantalVliegtuigen { get; private set; }


        static Vliegtuig()
        {
            AantalVliegtuigenInDeLucht = 0;
        }


        public Vliegtuig(int maxBrandstof)
        {
            MaxBrandstof = maxBrandstof;
        }


        private static decimal ConverteerNaarMijl(decimal afstand)
        {
            return afstand * 1.6M;
        }

        public void StijgOp()
        {
            AantalVliegtuigenInDeLucht++;
        }
        public void Land()
        {
            AantalVliegtuigenInDeLucht--;
        }

    }
}
