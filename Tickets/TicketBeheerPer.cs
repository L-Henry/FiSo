using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    public class TicketBeheerPer<TTicket>
        where TTicket : ITicket, new()
    {
        public int MaxAantal;
        public TTicket[] Tickets { get; set; }


        public TicketBeheerPer(int max, int aantal = 0)
        {
            MaxAantal = max;
            Tickets = new TTicket[aantal];
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
            if (CheckAantalGeldig() < MaxAantal)
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

        public void OngeldigMaken(string barcode)
        {
            for (int i = 0; i < Tickets.Length; i++)
            {
                if (Tickets[i].Barcode.Equals(barcode))
                {
                    Tickets[i].IsGeldig = false;
                }
            }
        }

        public void TicketVragen()
        { 
            if (CheckAantalGeldig() < MaxAantal)
            {
                AddTicket();
                Tickets[Tickets.Length - 1].IsGeldig = true;
            }
            else
            {
                throw new Exception("Geen beschikbare tickets meer.");
            }
        }
    }
}
