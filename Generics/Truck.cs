using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Truck<TCargo, TEngine> : ITruck<TCargo>
        where TCargo : ICargo
        where TEngine : new()
    {
        //public TCargo Cargo { get; set; }
        TCargo _cargo;
        public TEngine Engine { get; set; }

        public Truck(TEngine engine)
        {
            Engine = engine;
        }

        public void Load(TCargo cargo)
        {
            _cargo = cargo;
        }

        public TCargo UnLoad()
        {
            return _cargo;
        }



        

    }
}
