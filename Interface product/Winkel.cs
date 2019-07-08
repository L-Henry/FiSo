using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_product
{
    class Winkel
    {
        public IProduct[] Producten { get; set; }

        public Winkel()
        {
            Producten = new IProduct[0];

        }

        public void VoegProductToe(IProduct product)
        {
            IProduct[] tempProducten = new IProduct[Producten.Length + 1];
            for (int i = 0; i < tempProducten.Length - 1; i++)
            {
                tempProducten[i] = Producten[i];
            }
            tempProducten[tempProducten.Length - 1] = product;
            Producten = tempProducten;
        }

        public void ToonDetailsVanAlleProducten()
        {
            foreach (IProduct product in Producten)
            {
                product.ToonDetails();
            }
        }
    }
}
