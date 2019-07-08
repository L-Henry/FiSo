using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Wagenpark
    {

        private Wagen[] _wagens { get; set; }
        public Wagen this[int index]
        {
            get
            {
                return _wagens[index];
            }
            set
            {
                _wagens[index] = value;
            }
        }

    }
}
