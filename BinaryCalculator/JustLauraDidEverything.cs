using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    internal class BinaryMultiplicationLaura
    {
        public int BinaryMultiplicationMethod(string Binary1, string Binary2)
        {
            char[] charArray1 = Binary1.ToCharArray();
            Array.Reverse(charArray1);
            char[] charArray2 = Binary2.ToCharArray();
            Array.Reverse(charArray2);

            int lineWorth = 1; //Gilt für beide

            int arrayLength = charArray1.Length > charArray2.Length ? charArray1.Length : charArray2.Length;

            int a = 0;
            int b = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                a += i < charArray1.Length ? (charArray1[i] - 48) * lineWorth : 0; //-48 wegen Ascii Tabelle
                b += i < charArray2.Length ? (charArray2[i] - 48) * lineWorth : 0; //-48 wegen Ascii Tabelle

                lineWorth *= 2;
            }

            return a*b;
        }
    }
}
