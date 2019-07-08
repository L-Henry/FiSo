using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    public class Dier
    {
        public Dier(string geluid)
        {
            this.geluid = geluid;
        }
        private string geluid { get; set; }
        public string Geluid { get; set; }

        public virtual void MaakGeluid()
        {
            Console.WriteLine($"Dier zegt {Geluid}.");
        }

        protected void GeheimeFunctionaliteitVoorAlleDieren()
        {

        }


    }
}
