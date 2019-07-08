using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MonsterTruck : ITruck<BoxCargo>
    {
        public BoxCargo Cargo { get; set; }

        public void Load(BoxCargo cargo)
        {
            Cargo = cargo;
        }

        public BoxCargo UnLoad()
        {
            return Cargo;
        }
    }
}
