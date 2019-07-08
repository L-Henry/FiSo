using System;

namespace Generics
{
    class Program
    {
        public static T[] CreateArray<T>(int size)
        {
            return new T[size];
        }
        
        public static TGetal Som<TGetal>(params TGetal[] getallen) where TGetal : struct
        {

            dynamic resultaat = 0;
            for (int i = 0; i < getallen.Length; i++)
            {
                resultaat += getallen[i];
            }
            return resultaat;
        }



        static void Main(string[] args)
        {

            int[] intArray = CreateArray<int>(5);
            string[] stringArray = CreateArray<string>(5);
            Truck<BoxCargo, DieselMotor>[] truckArray = CreateArray<Truck<BoxCargo, DieselMotor>>(10);

            MonsterTruck monsterTruck = new MonsterTruck();
            BoxCargo monsterBoxCargo = new BoxCargo();
            monsterBoxCargo.BoxAmount = 5;
            monsterTruck.Load(monsterBoxCargo);

            SuperTruck<LiquidCargo> superTruck = new SuperTruck<LiquidCargo>();
            //superTruck.Cargo.BoxAmount = 50;
            //BoxCargo superBox = new BoxCargo();
            //LiquidCargo superLiquid = new LiquidCargo();
            //superBox.BoxAmount = 100;
            //superLiquid.Liters = 10000;
            //superTruck.Load(superLiquid);
            superTruck.Cargo.Liters = 100;

            Console.WriteLine(superTruck.UnLoad().Gewicht());

            
            

            /*
            TruckOud truckOud = new TruckOud();
            truckOud.Cargo = new BoxCargo();
            BoxCargo boxCargo = (BoxCargo)truckOud.Cargo;
            boxCargo.BoxAmount = 50;

            Console.WriteLine(boxCargo.ToString());
            Console.WriteLine(truckOud.Cargo.ToString());

            truckOud.Cargo = new LiquidCargo();
            LiquidCargo liquidCargo = (LiquidCargo)truckOud.Cargo;
            liquidCargo.Liters = 900;
            Console.WriteLine(truckOud.Cargo.ToString());
            */

            DieselMotor diesel = new DieselMotor();

            Truck<BoxCargo, DieselMotor> boxTruck = new Truck<BoxCargo, DieselMotor>(new DieselMotor());
            BoxCargo boxCargo = new BoxCargo();
            boxCargo.BoxAmount = 50;
            boxTruck.Load(boxCargo);
            Console.WriteLine(boxTruck.UnLoad().ToString());
            /*
            boxTruck.Cargo = new BoxCargo();
            boxTruck.Cargo.BoxAmount = 50;
            Console.WriteLine(boxTruck.Cargo.ToString());
            */
            Truck<LiquidCargo, DieselMotor> liquidTruck = new Truck<LiquidCargo, DieselMotor>(new DieselMotor());
            LiquidCargo liquidCargo = new LiquidCargo();
            liquidCargo.Liters = 900;
            liquidTruck.Load(liquidCargo);
            Console.WriteLine(liquidTruck.UnLoad().ToString());
            /*
            liquidTruck.Cargo = new LiquidCargo();
            liquidTruck.Cargo.Liters = 900;
            Console.WriteLine(liquidTruck.Cargo.ToString());
            */

            Console.ReadLine();
        }
    }
}
