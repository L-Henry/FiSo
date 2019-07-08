using System;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TicketBeheer<PersoneelTicket> personen = new TicketBeheer<PersoneelTicket>(800);
            TicketBeheer<ExternTicket> externen = new TicketBeheer<ExternTicket>(150);
            TicketBeheer<PartnersTicket> partners = new TicketBeheer<PartnersTicket>(50);


            for (int i = 0; i < 500; i++)
            {
                personen.TicketVragen();
            }
            personen.OngeldigMaken("Personeel1");

            Console.WriteLine(personen.CheckAantalGeldig());
            Console.WriteLine(personen.CheckAantalBeschikbaar());
            Console.WriteLine(personen.MaxAantal);
            Console.WriteLine(personen.Tickets.Length);
            */
            TicketBeheerPer<PersoneelTicket> personen = new TicketBeheerPer<PersoneelTicket>(800);
            TicketBeheerPer<ExternTicket> externen = new TicketBeheerPer<ExternTicket>(150);
            TicketBeheerPer<PartnersTicket> partners = new TicketBeheerPer<PartnersTicket>(50);


            for (int i = 0; i < 800; i++)
            {
                personen.TicketVragen();
            }
            personen.OngeldigMaken("Personeel1");
            personen.TicketVragen();

            Console.WriteLine(personen.CheckAantalGeldig());
            Console.WriteLine(personen.MaxAantal);
            Console.WriteLine(personen.Tickets.Length);



            Console.ReadLine();
        }
    }
}
