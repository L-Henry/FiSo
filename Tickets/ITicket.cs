using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    public interface ITicket
    {
        string Type { get; }
        bool IsGeldig { get; set; }
        bool IsBeschikbaar { get; set; }
        string Barcode { get; set; }
    }
}
