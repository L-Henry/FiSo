using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekemachine_met_classes
{
    class Rekenmachine
    {


        public Rekenmachine()
        {


        }

       

        internal double Som(double getal1, double getal2)
        {
            return getal1 + getal2;
        }

        internal double Verschil(double getal1, double getal2)
        {
            return getal1 - getal2;
        }

        internal double Product(double getal1, double getal2)
        {
            return getal1 * getal2;
        }

        internal double Quotient(double getal1, double getal2)
        {
            return getal1 / getal2;
        }


        internal double Bereken(string alles)
        {
            if (alles[0] == '-' && alles[1] == '-')
            {
                alles = alles.Remove(0, 2);
            }
            int lengte = alles.Length;

            if (double.TryParse(alles, out double test))
            {
                return double.Parse(alles);
            }
            //haakjes
            if (alles.IndexOf('(') >= 0)
            {
                int haakjeOpen = alles.LastIndexOf('(');
                string rest = alles.Substring(haakjeOpen + 1, lengte - haakjeOpen - 1);
                int haakjeToe = rest.IndexOf(')');
                string binnenHaakjes = rest.Substring(0, haakjeToe);
                string binnenHaakjesBerekend = Bereken(binnenHaakjes).ToString();
                if (haakjeOpen == 0)
                {
                    return Bereken(binnenHaakjesBerekend + rest.Substring(haakjeToe + 1, rest.Length - haakjeToe - 1));
                }
                else if (haakjeToe == rest.Length - 1)
                {
                    return Bereken(alles.Substring(0, haakjeOpen) + binnenHaakjesBerekend);
                }
                else
                {
                    return Bereken(alles.Substring(0, haakjeOpen) + binnenHaakjesBerekend + rest.Substring(haakjeToe + 1, rest.Length - haakjeToe - 1));
                }
            }
            //vermeigvuldig en deling
            for (int tel = 1; tel < lengte; tel++)
            {
                if (alles[tel] == '*' || alles[tel] == '/')
                {
                    int Index = tel;
                    int i = 0;
                    int j = 1;

                    while (Index - i > 0 && (Char.IsNumber(alles[Index - 1 - i]) || alles[Index - 1 - i] == ',' || (alles[Index - 1 - i] == '-' && tel - i - 1 > 0 && Char.IsSymbol(alles[Index - i - 2]))))//&& ( minIndex > 1 && Char.IsSymbol(alles[Index - i - 1]) ) ) ) )
                    {
                        i++;
                    }
                    while (Index + j < lengte - 1 && (Char.IsNumber(alles[Index + j + 1]) || alles[Index + j + 1] == ',' || (Char.IsSymbol(alles[Index]) && Char.IsSymbol(alles[Index + 1]))))
                    {
                        j++;
                    }

                    double min1 = double.Parse(alles.Substring(Index - i, i));
                    double min2 = double.Parse(alles.Substring(Index + 1, j));
                    double min;
                    if (alles[tel] == '*')
                    {
                        min = Product(min1, min2);
                    }
                    else
                    {
                        min = Quotient(min1, min2);
                    }
                    return Bereken(alles.Substring(0, Index - i) + min + alles.Substring(Index + j + 1, lengte - 1 - Index - j));
                }
            }
            //som en verschil
            for (int tel = 1; tel < lengte; tel++)
            {
                if ((alles[tel] == '-' && Char.IsNumber(alles[tel - 1])) || alles[tel] == '+')
                {
                    int Index = tel;
                    int i = 0;
                    int j = 1;

                    while (Index - i > 0 && (Char.IsNumber(alles[Index - 1 - i]) || alles[Index - 1 - i] == '-' || alles[Index - 1 - i] == ',')) //&& ( minIndex > 1 && Char.IsSymbol(alles[minIndex - i - 1]) ) ) ) )
                    {
                        i++;
                    }
                    while (Index + j < lengte - 1 && (Char.IsNumber(alles[Index + j + 1]) || alles[Index + j + 1] == ',' || (Char.IsSymbol(alles[Index]) && Char.IsSymbol(alles[Index + 1]))))
                    {
                        j++;
                    }

                    double min1 = double.Parse(alles.Substring(Index - i, i));
                    double min2 = double.Parse(alles.Substring(Index + 1, j));
                    double min;
                    if (alles[tel] == '-')
                    {
                        min = Verschil(min1, min2);
                    }
                    else
                    {
                        min = Som(min1, min2);
                    }
                    return Bereken(alles.Substring(0, Index - i) + min + alles.Substring(Index + j + 1, lengte - 1 - Index - j));
                }
            }
            //vergelijk
            for (int tel = 1; tel < lengte; tel++)
            {
                if (alles[tel] == '=' && Char.IsNumber(alles[tel - 1]))
                {
                    int Index = tel;
                    int i = 0;
                    int j = 1;

                    while (Index - i > 0 && (Char.IsNumber(alles[Index - 1 - i]) || alles[Index - 1 - i] == '-' || alles[Index - 1 - i] == ',')) //&& ( minIndex > 1 && Char.IsSymbol(alles[minIndex - i - 1]) ) ) ) )
                    {
                        i++;
                    }
                    while (Index + j < lengte - 1 && (Char.IsNumber(alles[Index + j + 1]) || alles[Index + j + 1] == ',' || (Char.IsSymbol(alles[Index]) && Char.IsSymbol(alles[Index + 1]))))
                    {
                        j++;
                    }

                    double min1 = double.Parse(alles.Substring(Index - i, i));
                    double min2 = double.Parse(alles.Substring(Index + 1, j));
                    double min;
                    if (min1 == min2)
                    {
                        min = 1;
                        Console.WriteLine($"{min1} is gelijk aan {min2}");
                    }
                    else
                    {
                        min = 0;
                        Console.WriteLine($"{min1} is niet gelijk gelijk aan {min2}");

                    }
                    return min;
                }
            }
            return 0;
        }

        internal string Binair(string input, int richting = 2)
        {
            int lengte = input.Length;
            string resultaat = string.Empty;
            bool richt = false;
            for (int i = 0; i < lengte; i++)
            {
                if (input[i] != '0' && input[i] != '1')
                {
                    richt = true;
                }
            }

            if (richting == 1 || richt) // decimaal -> binair
            {
                int getal = int.Parse(input);
                int rest;
                while (getal > 0)
                {
                    rest = getal % 2;
                    getal /= 2;
                    resultaat = rest.ToString() + resultaat;
                }
            }
            else if (richting == 2 || richt == false) //binair -> decimaal
            {
                int[] getal = new int[lengte];
                double result = 0;
                for (int i = 0; i < lengte; i++)
                {
                    getal[i] = Convert.ToInt32(Char.GetNumericValue(input[i]));
                }
                for (int i = lengte - 1; i >= 0; i--)
                {
                    if (getal[i] == 1)
                    {
                        result += Math.Pow(2, lengte - 1 - i);
                    }
                }
                resultaat = result.ToString();
            }
            return resultaat;
        }

        public bool IsGelijk(string min1, string min2)
        {
            double getal1 = double.TryParse(min1, out double t1) ? double.Parse(min1) : Bereken(min1);
            double getal2 = double.TryParse(min2, out double t2) ? double.Parse(min2) : Bereken(min2);

            if (getal1 == getal2)
            {
                Console.WriteLine($"{min1} is gelijk aan {min2}");
                return true;
            }
            else
            {
                Console.WriteLine($"{min1} is niet gelijk gelijk aan {min2}");
                return false;
            }
        }


    }
}
