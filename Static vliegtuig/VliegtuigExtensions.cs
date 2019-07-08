using System;
using System.Collections.Generic;
using System.Text;

namespace Static_vliegtuig
{
    public static class VliegtuigExtensions
    {
        public static void Vlieg(this Vliegtuig eenVliegtuig)
        {
            eenVliegtuig.Brandstof--;
            Console.WriteLine("Ik vlieg.");
        }


    }
}
