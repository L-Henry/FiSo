using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drankautomaat
{
    class DrankAutomaat
    {
        public DrankStock[] Stock { get; set; }
        public decimal HoeveelGeldInSlot { get; set; } = 0;


        public DrankAutomaat()
        {
            Stock = new DrankStock[0];
        }

        internal void ToonBeschikbareDranken()
        {
            Console.WriteLine("Beschikbare dranken:");
            for (int i = 0; i < Stock.Length; i++)
            {
                Console.WriteLine($"{i+1}) {Stock[i].NaamDrank}, {Stock[i].Prijs}€, nog {Stock[i].Aantal} beschikbaar.");
            }
            Console.WriteLine();
        }

        internal void SteekGeldInAutomaat(decimal hoeveel)
        {
            HoeveelGeldInSlot += hoeveel;
        }

        internal decimal GeefMijnGeldTerug(decimal hoeveel, decimal prijs)
        {
            Console.WriteLine($"U krijgt {prijs - hoeveel}€ terug.");
            Console.WriteLine();
            HoeveelGeldInSlot = 0M;
            return prijs - hoeveel;
        }

        internal void KoopDrank()
        {
            Console.WriteLine("Kies een drank.");
            ToonBeschikbareDranken();
            Console.WriteLine();
            int welke = int.Parse(Console.ReadLine());
            if (HoeveelGeldInSlot >= Stock[welke - 1].Prijs && Stock[welke - 1].Aantal > 0)
            {
                GeefMijnGeldTerug(Stock[welke - 1].Prijs, HoeveelGeldInSlot);
                Stock[welke - 1].Aantal--;
            }
            else if (HoeveelGeldInSlot < Stock[welke - 1].Prijs)
            {
                Console.WriteLine("Onvoldoende geld in slot.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{Stock[welke - 1].NaamDrank} is op.");
            }
        }

        internal void VoegStockToe(DrankStock drank)
        {
            bool naamCheck = false;
            int tel = 0;
            for (int i = 0; i < Stock.Length; i++)
            {
                if (drank.NaamDrank == Stock[i].NaamDrank)
                {
                    tel = i;
                    naamCheck = true;
                }
            }
            if (naamCheck)
            {
                Stock[tel].Aantal += drank.Aantal;
            }
            else
            {
                DrankStock[] tempStock = new DrankStock[Stock.Length + 1];
                for (int i = 0; i < tempStock.Length - 1; i++)
                {
                    tempStock[i] = Stock[i];
                }
                tempStock[tempStock.Length - 1] = drank;
                Stock = tempStock;
            }
        }
        internal void VoegStockToe()
        {
            Console.WriteLine("Wat wilt u toevoegen?");
            Console.WriteLine("Geef naam, prijs en aantal in.");
            Console.WriteLine();
            string[] input = Console.ReadLine().Split(',');
            DrankStock nieuweDrank = new DrankStock(input[0], Convert.ToDecimal(input[1]), Convert.ToInt32(input[2]));
            VoegStockToe(nieuweDrank);
        }


    }
}
