using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    class RegisseurManager
    {
        public Regisseur[] Regisseurs { get; private set; }

        public RegisseurManager()
        {
            Regisseurs = new Regisseur[0];
        }

        internal Regisseur VindRegisseur(string naam)
        {
            int tel = 0;
            bool check = false;
            for (int i = 0; i < Regisseurs.Length; i++)
            {
                if (Regisseurs[i].Naam == naam)
                {
                    tel = i;
                    check = true;
                }
            }
            if (check == true)
            {
                return Regisseurs[tel];
            }
            else
            {
                Console.WriteLine("Regisseur niet gekend.");
                VoegRegisseurToe();
                return Regisseurs[Regisseurs.Length - 1];
            }
        }

        internal void VoegRegisseurToe()
        {
            Console.WriteLine("Maak nieuwe regisseur aan door naam en geboortedatum in te geven.");
            Console.WriteLine("Geef naam in.");
            string nieuweNaam = Console.ReadLine();
            Console.WriteLine("Geef geboortedatum in.");
            DateTime datum = Convert.ToDateTime(Console.ReadLine());
            Regisseur nieuweRegisseur = new Regisseur(nieuweNaam, datum);
            Regisseur[] tempRegisseurs = new Regisseur[Regisseurs.Length + 1];
            for (int j = 0; j < tempRegisseurs.Length - 1; j++)
            {
                tempRegisseurs[j] = Regisseurs[j];
            }
            tempRegisseurs[tempRegisseurs.Length - 1] = nieuweRegisseur;
            Regisseurs = tempRegisseurs;
        }

        internal void VoegRegisseurToe(Regisseur nieuweRegisseur)
        {
            Regisseur[] tempRegisseurs = new Regisseur[Regisseurs.Length + 1];
            for (int j = 0; j < tempRegisseurs.Length - 1; j++)
            {
                tempRegisseurs[j] = Regisseurs[j];
            }
            tempRegisseurs[tempRegisseurs.Length - 1] = nieuweRegisseur;
            Regisseurs = tempRegisseurs;
        }

    }
}
