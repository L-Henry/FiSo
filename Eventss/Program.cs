using System;

namespace Eventss
{
    class Program
    {
        static void Main(string[] args)
        {

            var calculator = new Calculator();

            calculator.OnCalculationEvent += Calculator_OnCalculationEvent;

            calculator.OnCalculationEvent += (sender, e) => Console.WriteLine($"Anoniem: Getal1: {e.Getal1}, Getal2: {e.Getal2}");

            calculator.RaiseCalculationEvent(5, 10);








            Console.ReadLine();
        }


        private static void Calculator_OnCalculationEvent(object sender, OnCalculationEventsArgs e)
        {
            Console.WriteLine( $"Getal1: {e.Getal1}, Getal2: {e.Getal2}" );
        }
    }
}
