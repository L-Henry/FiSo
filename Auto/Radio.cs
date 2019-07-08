using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Radio
    {
        public int Volume { get; set; } = 5;
        public string HuidigeZender { get; set; } = "Radio 1";

        public string MerkNaam { get; }

        public bool StaatAan { get; set; }

        public Radio(string merk)
        {
            MerkNaam = merk;
        }

        internal void VerhoogVolume()
        {
            if (Volume < 10)
            {
                Volume++;
                Console.WriteLine($"Volume is nu {Volume}");
            }
            else
            {
                Console.WriteLine("Volume kan niet hoger, max is 10.");
            }
        }

        internal void VerlaagVolume()
        {
            if (Volume > 0)
            {
                Volume--;
                Console.WriteLine($"Volume is nu {Volume}");
            }
            else
            {
                Console.WriteLine("Volume kan niet lager, min is 0.");
            }
        }

        internal void Aanzetten()
        {
            StaatAan = true;
            Console.WriteLine("Muziek aan.");
        }

        internal void Uitzetten()
        {
            StaatAan = false;
            Console.WriteLine("Muziek stil.");
        }

        internal void VeranderZender(string zender)
        {
            HuidigeZender = zender;
        }

    }
}
