using System;

namespace Static_vliegtuig
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            MyStaticClass.MyStaticMethod();

            MyNonStaticClass myNonStaticClass = new MyNonStaticClass();
            myNonStaticClass.MyNonStaticMethod();

            MyStaticClass.MyStaticString = "Hello";
            Console.WriteLine(MyStaticClass.MyStaticString);
            */
            /*
            Vliegtuig vliegtuig = new Vliegtuig(1000);
            Tanktools.TankVol(vliegtuig);
            
            vliegtuig.StijgOp();

            VliegtuigExtensions.Vlieg(vliegtuig);

            vliegtuig.Land();

            Console.WriteLine(vliegtuig.Brandstof);
           */

            string test = "vdab";
            test.IsVdab();
            string test2 = "ander";
            test2.IsVdab();

            StringExtension.IsVdab("VDAB");
            StringExtension.IsVdab("vdab");
            StringExtension.IsVdab("heheh");

            

            Console.ReadLine();

        }
    }
}
