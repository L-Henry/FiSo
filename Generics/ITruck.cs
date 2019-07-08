using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public interface ITruck<TCargo> where TCargo : ICargo
    {

        void Load(TCargo cargo);
        TCargo UnLoad();


    }
}
