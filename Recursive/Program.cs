using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Recursive
{
    class Program
    {

        /*
        private static void OefRecurief()
        {
            string path = "c:\\";
            PrintFolder(path, "");
        }



        private static void PrintFolder(string path, string preFix)
        {
            //Console.WriteLine(path);
            //string preFix = "   ";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            Console.WriteLine();
            Console.WriteLine(preFix + directoryInfo.Name);

            try
            { 
                string[] subFolders = Directory.GetDirectories(path);
                preFix += "  ";

                foreach (string subFolder in subFolders)
                {
                    PrintFolder(subFolder, preFix);
                }
            }
            catch (Exception)
            {
                //throw;
                ;
            }
        }
        */

        static int VoegRecursiefToe(int getal, int aantal)
        {
            int resultaat = getal;
            if (aantal > 0)
            {
                resultaat++;
                return VoegRecursiefToe(resultaat, --aantal);
            }
            else if (aantal < 0)
            {
                resultaat--;
                return VoegRecursiefToe(resultaat, ++aantal);
            }
            return resultaat;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Geef getal en aantal toevoeginge in.");
            int getal = Convert.ToInt32(Console.ReadLine());
            int aantal = Convert.ToInt32(Console.ReadLine());
            int recursief = VoegRecursiefToe(getal, aantal);
            Console.WriteLine($"De uitkomst van recursieve optelling is {recursief}");
            

            //OefRecurief();
           






            Console.ReadLine();
        }
    }
}
