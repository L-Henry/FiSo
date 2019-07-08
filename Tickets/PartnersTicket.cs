using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class PartnersTicket : ITicket
    {
        public string Type { get; } = "Partners";
        public bool IsGeldig { get; set; }
        public bool IsBeschikbaar { get; set; } = true;
        public string Barcode { get; set; }
    }
}
