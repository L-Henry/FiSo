using System;
using System.Collections.Generic;
using System.Text;

namespace Static_vliegtuig
{
    public static class MyStaticClass
    {
        public static string MyStaticString { get; set; }

        static MyStaticClass()
        {
            Console.WriteLine("Hallo vanuit static class.");
        }

        public static void MyStaticMethod()
        {
            
        }

        public static int MyStaticProperty { get; set; }

    }
}
