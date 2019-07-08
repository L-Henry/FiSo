using System;
using System.Drawing;

namespace IRacer
{
    class Program
    {
        static void Main(string[] args)
        {

            Racebaan circuit = new Racebaan(new Point(4, 50000), 10);
            Banden soft = new Banden(4.3);
            Banden medium = new Banden(3);
            Banden hard = new Banden(1.6);


            IRacer lambo = new Lamborghini(new Point(2, 0), 240, "lambo", soft);
            IRacer ferrari = new Lamborghini(new Point(3, 0), 255, "ferrari", medium);
            IRacer renault = new Lamborghini(new Point(2, -1), 200, "renault", hard);
            IRacer speelgoed = new Lamborghini(new Point(3, -1), 255, "speelgoed", medium);

            circuit.VoegRacerToe(lambo);
            circuit.VoegRacerToe(ferrari);
            circuit.VoegRacerToe(renault);
            circuit.VoegRacerToe(speelgoed);

            circuit.StartRace();



            Console.ReadLine();
        }
    }
}
