using System;
using System.Collections.Generic;
using System.Text;

namespace Immokantoor
{
    class ImmoKantoor
    {
        public Gebouw[] Gebouwen { get; set; }

        public ImmoKantoor(string Naam)
        {
            Gebouwen = new Gebouw[0];
        }

        internal void VoegGebouwToe(Gebouw gebouw)
        {
            Gebouw[] tempGebouwen = new Gebouw[Gebouwen.Length + 1];
            for (int i = 0; i < tempGebouwen.Length - 1; i++)
            {
                tempGebouwen[i] = Gebouwen[i];
            }
            tempGebouwen[tempGebouwen.Length - 1] = gebouw;
            Gebouwen = tempGebouwen;
        }

        internal void ToonMijAlleAppartementen()
        {
            foreach (Gebouw gebouw in Gebouwen)
            {
                if (gebouw is Appartement)
                {
                    gebouw.WatZijnMijnDetails();
                }
            }
        }

        internal void ToonMijAlleHuizen()
        {
            foreach (Gebouw gebouw in Gebouwen)
            {
                if (gebouw is Huis)
                {
                    gebouw.WatZijnMijnDetails();
                }
            }
        }


    }
}
