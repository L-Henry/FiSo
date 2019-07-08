using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Winkelmand
    {

        public Product[] Producten { get; private set; }

        public Winkelmand()
        {
            Producten = new Product[0];
        }

        public void ToonProductOverzicht()
        {
            Console.WriteLine("Producten:");
            for (int i = 0; i < Producten.Length; i++)
            {
                Console.WriteLine($"{i+1}) {Producten[i].ProductNaam} {Producten[i].Prijs}");
            }
            Console.WriteLine();
        }

        internal void VoegProductToe(Product product)
        {
            Product[] _productTemp = new Product[Producten.Length + 1];
            for (int i = 0; i < _productTemp.Length - 1; i++)
            {
                _productTemp[i] = Producten[i];
            }
            _productTemp[_productTemp.Length - 1] = product;
            Producten = _productTemp;
        }

        internal void BerekenTotaalPrijs()
        {
            int totaalPrijs = 0;
            for (int i = 0; i < Producten.Length; i++)
            {
                totaalPrijs += Producten[i].Prijs;
            }
            Console.WriteLine($"Totaalprjs is {totaalPrijs}");
            Console.WriteLine();
        }

        internal void MaakMandjeLeeg()
        {
            Producten = new Product[0];
        }

        internal void VerwijderProduct(int welk)
        {
            Product[] _productTemp = new Product[Producten.Length - 1];
            for (int i = 0; i < welk - 1; i++)
            {
                _productTemp[i] = Producten[i];
            }
            for (int i = welk - 1; i <  Producten.Length - 1; i++)
            {
                _productTemp[i] = Producten[i + 1];
            }
            Producten = _productTemp;
        }

    }
}
