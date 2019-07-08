using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class PersoneelTicket : ITicket
    {
        public string Type { get; } = "Personeel";
        public bool IsGeldig { get; set; }
        public bool IsBeschikbaar { get; set; } = true;
        public string Barcode { get; set; }

    }
}
