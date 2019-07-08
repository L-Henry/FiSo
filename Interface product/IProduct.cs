using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_product
{
    interface IProduct
    {
        string Merknaam { get; set; }
        string Modelnaam { get; set; }
        decimal Prijs { get; set; }

        void ToonDetails();
    }
}
