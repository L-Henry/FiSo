using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Quiz
    {
        public VraagAntwoord[] VraagAntwoorden { get; set; }
        public string Naam { get; set; }

        public VraagAntwoord this[int index]
        {
            get { return VraagAntwoorden[index]; }
            set { VraagAntwoorden[index] = value; }
        }


        public Quiz(string naam)
        {
            Naam = naam;
            VraagAntwoorden = new VraagAntwoord[0];
        }

        public void VoegVraagAntwoodToe(VraagAntwoord vraagAntwoord)
        {
            VraagAntwoord[] tempVA = new VraagAntwoord[VraagAntwoorden.Length + 1];
            for (int i = 0; i < tempVA.Length - 1; i++)
            {
                tempVA[i] = VraagAntwoorden[i];
            }
            tempVA[tempVA.Length - 1] = vraagAntwoord;
            VraagAntwoorden = tempVA;
        }

        public void CheckAntwoord(string antwoord, VraagAntwoord vraagAntwoord)
        {
            if (vraagAntwoord.Antwoord.ToLower() == antwoord.ToLower())
            {
                Console.WriteLine("Correct.");
            }
            else
            {
                Console.WriteLine("Fout.");
            }
        }

        public int GeefWillekeurigVraag()
        {
            int rInt = 0;
            do
            {
                Random r = new Random();
                rInt = r.Next(0, VraagAntwoorden.Length);
            } while (VraagAntwoorden[rInt].Gedaan);

            Console.WriteLine($"{VraagAntwoorden[rInt].Vraag}");
            VraagAntwoorden[rInt].Gedaan = true;

            return rInt;
        }

    }
}
