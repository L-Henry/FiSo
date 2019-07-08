using System;
using System.Collections.Generic;
using System.Text;

namespace Static_vliegtuig
{
    public static class StringExtension
    {
        public static void IsVdab(this String inputString)
        {
            if (inputString.ToUpper() == "VDAB")
            {
                Console.WriteLine("Ja.");
            }
            else
            {
                Console.WriteLine("Neen");
            }
        }

    }
}
