using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class TruckOud
    {
        public object Cargo { get; set; }

        public TruckOud(object cargo)
        {
            Cargo = cargo;
        }

        public TruckOud()
        {

        }

    }
}
