using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class VraagAntwoord
    {
        public string Vraag { get; set; }
        public string Antwoord { get; set; }
        public bool Gedaan { get; set; }

        public VraagAntwoord(string vraag, string antwoord)
        {
            Vraag = vraag;
            Antwoord = antwoord;
        }

    }
}
