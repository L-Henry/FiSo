using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_aanmaken
{
    public class Auto
    {

        private readonly string _merkNaam;

        public string Brandstof { get; set; }

        private int _aantalPK;
        public int PK
        {
            get { return _aantalPK; }
            set { _aantalPK = value; }
        }

        private string _kleur;
        public string Kleur
        {
            get
            {
                if (_kleur == null)
                {
                    return "Geen kleur";
                }
                else
                {
                    return _kleur;
                }
            }
            set
            {
                _kleur = value;
            }     
        }
        

        public Auto(string merkNaam = "leeg", int aantalPK = 0, string brandstof = "leeg")
        {
            _merkNaam = merkNaam;
            _aantalPK = aantalPK;
            Brandstof = brandstof;
        }

        public Auto()
        {

        }

        public void Start()
        {
            
        }

        public int Opdrijven(int hoeveel = 10)
        {
            _aantalPK += hoeveel;
            return _aantalPK;
        }

       
        
    }
}
