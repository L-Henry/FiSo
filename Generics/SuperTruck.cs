using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class SuperTruck<TSuperTruckCargo> : ITruck<TSuperTruckCargo>
        where TSuperTruckCargo : ICargo, ILiquidCargo, new()
    {
        public TSuperTruckCargo Cargo { get; set; }

        public SuperTruck()
        {
            Cargo = new TSuperTruckCargo();
        }

        public void Load(TSuperTruckCargo cargo)
        {
            Cargo = cargo;
        }

        public TSuperTruckCargo UnLoad()
        {
            return Cargo;
        }
    }
}
