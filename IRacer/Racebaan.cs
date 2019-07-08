using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace IRacer
{
    class Racebaan
    {
        public IRacer[] Circuit { get; set; }

        public Point FinishPositie { get; set; }

        public int Bochten { get; set; }
        

        public Racebaan(Point finish, int bochten)
        {
            FinishPositie = finish;
            Circuit = new IRacer[0];
            Bochten = bochten;
        }

        public void VoegRacerToe(IRacer racer)
        {
            IRacer[] tempCircuit = new IRacer[Circuit.Length + 1];
            for (int i = 0; i < tempCircuit.Length - 1; i++)
            {
                tempCircuit[i] = Circuit[i];
            }
            tempCircuit[tempCircuit.Length - 1] = racer;
            Circuit = tempCircuit;
        }

        public void StartRace()
        {
            int gewonnen = 0;
            int teller = 0;
            int uitgevallen = 0;
            do
            {
                for (int i = 0; i < Circuit.Length; i++)
                {
                    for (int j = 0; j < Circuit.Length; j++)
                    {
                        if (Circuit[i].Positie.X == Circuit[j].Positie.X && Circuit[j].Positie.Y + Circuit[j].PositieIncrementer > Circuit[i].Positie.Y)
                        {
                            Circuit[j].GaPositieNaarVoor(Bochten);
                            Circuit[j].Positie = new Point(Circuit[j].Positie.X + 1, Circuit[j].Positie.Y - 5);
                        }
                        else
                        {
                            Circuit[j].GaPositieNaarVoor(Bochten);
                        }
                    }
                    if (Circuit[i].Banden.Grip <= 0 && !Circuit[i].Gewonnen)
                    {
                        uitgevallen++;
                        Circuit[i].Gewonnen = true;
                        Console.WriteLine($"{Circuit[i].NaamBestuurder} is uitgevallen.");
                    }

                    if (gewonnen < 1 && !Circuit[i].Gewonnen && Circuit[i].Positie.Y >= FinishPositie.Y)
                    {
                        gewonnen++;
                        Circuit[i].Gewonnen = true;
                        Console.WriteLine($"{Circuit[i].NaamBestuurder} is gewonnen na {teller} minuten.");
                    }
                    else if (Circuit[i].Gewonnen == false && Circuit[i].Positie.Y >= FinishPositie.Y)
                    {
                        gewonnen++;
                        Circuit[i].Gewonnen = true;
                        Console.WriteLine($"{Circuit[i].NaamBestuurder} kwam na {teller} minuten aan als {gewonnen}de.");

                    }
                }
                teller++;
            } while (gewonnen + uitgevallen < Circuit.Length);
        }
    }
}
