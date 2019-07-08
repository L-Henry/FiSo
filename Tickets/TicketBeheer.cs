using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    public class TicketBeheer<TTicket>
        where TTicket : ITicket, new()
    {
        public int MaxAantal;
        public TTicket[] Tickets { get; set; }


        public TicketBeheer(int max)
        {
            MaxAantal = max;
            Tickets = new TTicket[max];
            GenereerBarcodes();
        }

        public void GenereerBarcodes()
        {
            for (int i = 0; i < Tickets.Length; i++)
            {
                Tickets[i] = new TTicket();
                Tickets[i].Barcode = Tickets[i].Type + (i + 1).ToString();
            }
        }

        public void AddTicket()
        {
            if (CheckAantalBeschikbaar() + CheckAantalGeldig() < MaxAantal)
            {
                TTicket[] temp = new TTicket[Tickets.Length + 1];
                for (int i = 0; i < temp.Length - 1; i++)
                {
                    temp[i] = Tickets[i];
                }
                temp[temp.Length - 1] = new TTicket();
                temp[temp.Length - 1].Barcode = temp[temp.Length - 1].Type + temp.Length.ToString();
                Tickets = temp;
            }
        }

        public int CheckAantalGeldig()
        {
            int teller = 0;
            for (int i = 0; i < Tickets.Length; i++)
            {
                if (Tickets[i].IsGeldig)
                {
                    teller++;
                }
            }
            return teller;
        }

        public int CheckAantalBeschikbaar()
        {
            int teller = 0;
            for (int i = 0; i < Tickets.Length; i++)
            {
                if (Tickets[i].IsBeschikbaar)
                {
                    teller++;
                }
            }
            return teller;
        }

        public void OngeldigMaken(string barcode)
        {
            for (int i = 0; i < Tickets.Length; i++)
            {
                if (Tickets[i].Barcode.Equals(barcode))
                {
                    Tickets[i].IsGeldig = false;
                }
            }
            AddTicket();
        }

        public void TicketVragen()
        {
            if (CheckAantalBeschikbaar() > 0)
            {
                for (int i = 0; i < Tickets.Length; i++)
                {
                    if (Tickets[i].IsBeschikbaar)
                    {
                        Tickets[i].IsBeschikbaar = false;
                        Tickets[i].IsGeldig = true;
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("Geen beschikbare tickets meer.");
            }
        }
    }
}
