using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public interface ILiquidCargo : ICargo
    {
        int Liters { get; set; }

    }
}
