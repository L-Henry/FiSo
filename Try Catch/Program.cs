using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    class Program
    {
        private static void ExceptionHandling()
        {
            try
            {
                //CatchError(); // error is afgehandeld hier, dus gaat hij terug voort in de try
                CatchErrorFailedToResolve();
                Console.WriteLine("Geen error!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"ExceptionHandling Error: {e.Message}");
                Console.WriteLine($"Stacktrace: {e.StackTrace}");
            }
            /*
            try
            {
                int a = 5;
                int b = 0;
                int resultaat = a / b;
                Console.WriteLine($"Het resultaat is {resultaat}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Er is een fout gebeurd.");
            }
            */
        }

        private static void ThrowError()
        {
            throw new Exception("ThrowError, Zelfgemaakte fout");
        }
        private static void RoepThrowErrorOp()
        {
            ThrowError();
        }

        private static void ExceptionThrow()
        {
            try
            {
                ThrowError();
            }
            catch (Exception e)
            {
                Console.WriteLine($"ExceptionThrowError: {e.Message}");
            }
        }

        private static void CatchError()
        {
            try
            {
                ThrowError();
            }
            catch (Exception e)
            {
                Console.WriteLine($"CatchError: {e.Message}");
            }
        }

        private static void CatchErrorFailedToResolve()
        {
            try
            {
                ThrowError();
            }
            catch (Exception e)
            {
                Console.WriteLine("Proberen op te lossen ...");
                Console.WriteLine("... Mislukt");
                throw; //gaat hoger om daar te zien of er een catch is
            }
        }

        static void Main(string[] args)
        {
            //ExceptionHandling();


            Console.ReadLine();
        }
    }
}
