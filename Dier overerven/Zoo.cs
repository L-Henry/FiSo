using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    class Zoo
    {
        public Dier[] _dieren { get; set; }

        public Zoo()
        {
            _dieren = new Dier[2];
            _dieren[0] = new Merel("Merel tsjirp");
            _dieren[1] = new Mus("Mus tsjirp");
        }


        public void ProduceerGeluid()
        {
            foreach (Dier dier in _dieren)
            {
                dier.MaakGeluid();

                if (dier is Vogel)
                {
                    Vogel gecasteVogel = dier as Vogel;
                    gecasteVogel.Vlieg();
                }
                else if (dier is Vis)
                {
                    Vis gecasteVis = dier as Vis;
                    gecasteVis.Zwem();
                }
                else if (dier is Reptiel)
                {
                    Reptiel gecasteKrokodil = dier as Reptiel;
                    gecasteKrokodil.Kruip();
                }
                else if (dier is Zoogdier)
                {
                    Zoogdier gecasteZoogdier = (Zoogdier)dier;
                    gecasteZoogdier.Stap();
                }
            }
        }

        public void VoegDierToe(Dier dier)
        {
            Dier[] tempDieren = new Dier[_dieren.Length + 1];
            for (int i = 0; i < _dieren.Length; i++)
            {
                tempDieren[i] = _dieren[i];
            }
            tempDieren[tempDieren.Length - 1] = dier;
            _dieren = tempDieren;

        }

        public void LaatAlleVogelsVliegen()
        {
            foreach (Dier dier in _dieren)
            {
                if (dier is Vogel)
                {
                    Vogel gecasteVogel = dier as Vogel;
                    gecasteVogel.Vlieg();
                }
            }
        }

        public void LaatAlleApenBrullen()
        {
            foreach (Dier dier in _dieren)
            {
                if (dier is Aap)
                {
                    dier.MaakGeluid();
                }
            }
        }

        public void LaatAlleGoudvissenZwemmen()
        {
            foreach (Dier dier in _dieren)
            {
                if (dier is Goudvis)
                {
                    Goudvis goudvis = dier as Goudvis;
                    goudvis.Zwem();
                }
            }
        }

        public void LaatAlleReptielenEierenLeggen()
        {
            foreach (Dier dier in _dieren)
            {
                if (dier is Reptiel)
                {
                    Reptiel reptiel = dier as Reptiel;
                    reptiel.LegEi();
                }
            }
        }

        public void LaatAlleVogelsTsjirpen()
        {
            foreach (Dier dier in _dieren)
            {
                if (dier is Vogel)
                {
                    Vogel vogel = dier as Vogel;
                    vogel.MaakGeluid();
                }
            }
        }

        public void LaatAlleZoogDierenBevallen()
        {
            foreach (Dier dier in _dieren)
            {
                if (dier is Zoogdier)
                {
                    Zoogdier zoogdier = dier as Zoogdier;
                    zoogdier.Beval();
                }
            }
        }

        public void LaatAlleGooillasMetVuistenSlaan()
        {
            foreach (Dier dier in _dieren)
            {
                if (dier is Gorilla)
                {
                    Gorilla gorilla = dier as Gorilla;
                    gorilla.Slaan();
                }
            }
        }

        public bool IsDitEenGorilla(Dier dier)
        {
            return dier is Gorilla;
        }


    }
}
