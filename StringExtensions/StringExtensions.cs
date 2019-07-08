using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class StringExtensions
    {

        public static string Reverse(this String text)
        {

            string tempString = "";
            for (int i = 0; i < text.Length; i++)
            {
                tempString += text[text.Length - 1 - i];
            }
            return tempString;
        }

        public static string Repeat(this String text, int aantal)
        {
            string repeatString = "";
            for (int i = 0; i < aantal; i++)
            {
                repeatString += text;
            }
            return repeatString;
        }



    }
}
