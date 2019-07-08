using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        private string _merkNaam;
        public string MerkNaam
        {
            get
            {
                return _merkNaam;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Geef gedlig merknaam in.");
                }
                else
                {
                    _merkNaam = value;
                }
            }
        }

        private string _productNaam;
        public string ProductNaam
        {
            get
            {
                return _productNaam;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Geef gedlig productnaam in.");
                }
                else
                {
                    _productNaam = value;
                }
            }
        }

        private int _prijs;
        public int Prijs
        {
            get
            {
                return _prijs;
            }
            set
            {
                if (value > 0)
                {
                    _prijs = value;

                }
                else
                {
                    throw new Exception("Geef gedlige prijs in.");
                }
            }
        }

        public Product(string merkNaam, string productNaam, int prijs)
        {
            MerkNaam = merkNaam;
            ProductNaam = productNaam;
            Prijs = prijs;
        }

    }
}
