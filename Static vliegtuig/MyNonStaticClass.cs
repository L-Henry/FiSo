using System;
using System.Collections.Generic;
using System.Text;

namespace Static_vliegtuig
{
    class MyNonStaticClass
    {
        public static string MyStaticProperty { get; set; }
        public string MyNonStaticProperty { get; set; }

        static MyNonStaticClass()
        {
            Console.WriteLine("Hello vanuit non static class.");
        }


        public static void MyStaticMethod()
        {
            
        }

        public void MyNonStaticMethod()
        {
            
        }




    }
}
