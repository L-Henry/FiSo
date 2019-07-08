using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Auto
    {

        public string MerkNaam { get;  }
        public string Kleur { get; set; }

        public Motor Motor { get; }
        public int AantalLiterInTank { get; private set; } = 0;
        public bool IsAanHetDraaien { get; private set; } = false;
        public int MaxAantalLiter { get; private set; }

        public Wiel LinkerVoorwiel { get; }
        public Wiel RechterVoorwiel { get; }
        public Wiel LinkerAchterwiel { get; }
        public Wiel RechterAchterwiel { get; }

        public Radio Radio { get; }


        public Auto(string naam, string kleur, Motor motor, int maxLiter, int wielGrootte, string radioNaam)
        {
            MerkNaam = naam;
            Kleur = kleur;
            Motor = motor;
            MaxAantalLiter = maxLiter;
            LinkerVoorwiel = new Wiel(wielGrootte);
            RechterVoorwiel = new Wiel(wielGrootte);
            LinkerAchterwiel = new Wiel(wielGrootte);
            RechterAchterwiel = new Wiel(wielGrootte);
            Radio = new Radio(radioNaam);
        }

        public void Start()
        {
            Motor.Start();
            Radio.Aanzetten();
            IsAanHetDraaien = true;
            Console.WriteLine("Motor is gestart.");
        }

        public void Stop()
        {
            Motor.Stop();
            Radio.Uitzetten();
            IsAanHetDraaien = false;
            Console.WriteLine("Motor is gestopt.");
        }

        public void GeefGas()
        {
            if (IsAanHetDraaien == false)
            {
                throw new Exception("Motor staat uit.");
            }
            else if (Motor.Brandstof == "Batterij")
            {
                LinkerVoorwiel.DraaiRond();
                RechterVoorwiel.DraaiRond();
                LinkerAchterwiel.DraaiRond();
                RechterAchterwiel.DraaiRond();
            }
            else if (AantalLiterInTank >= 1)
            {
                LinkerVoorwiel.DraaiRond();
                RechterVoorwiel.DraaiRond();
                LinkerAchterwiel.DraaiRond();
                RechterAchterwiel.DraaiRond();
                AantalLiterInTank--;
            }
            else
            {
                throw new Exception("Geen brandstof meer.");
            }
        }

        public void Remmen()
        {
            LinkerVoorwiel.StopMetDraaien();
            RechterVoorwiel.StopMetDraaien();
            LinkerAchterwiel.StopMetDraaien();
            RechterAchterwiel.StopMetDraaien();
        }

        public void Tanken(int aantalLiter)
        {
            if (IsAanHetDraaien == true)
            {
                Console.WriteLine("Auto eerst uitzetten.");
            }
            else if (Motor.Brandstof == "Batterij")
            {
                Console.WriteLine("Tanken kan niet. Wagen moet opgeladen worden.");
            }
            else if (AantalLiterInTank + aantalLiter <= MaxAantalLiter)
            {
                AantalLiterInTank += aantalLiter;
            }
            else
            {
                Console.WriteLine("Tank zou overlopen.");
            }
        }

    }
}
