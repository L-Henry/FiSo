using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Motor
    {
        public int AantalPK { get; private set; }
        public string Brandstof { get;  }
        public int MaxToerental { get; private set; }
        private bool _motorStatus = false;

        public Motor(int pk, string brandstof, int toerental)
        {
            AantalPK = pk;
            Brandstof = brandstof;
            MaxToerental = toerental;
        }

        internal void Start()
        {
            _motorStatus = true;
        }

        internal void Stop()
        {
            _motorStatus = false;
        }

    }
}
