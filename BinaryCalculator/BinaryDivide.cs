using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    internal class BinaryDivide
    {
        public int solution1 {get;set;}
        public int solution2 { get;set;}
        public int BinaryDivideMethod(string Binary1, string Binary2)
        {
            char[] charArray1 = Binary1.ToCharArray();
            Array.Reverse(charArray1);
            char[] charArray2 = Binary2.ToCharArray();
            Array.Reverse(charArray2);

            int lineWorth = 1; //Gilt für beide

            int arrayLength = charArray1.Length > charArray2.Length ? charArray1.Length : charArray2.Length;




            for (int i = 0; i < arrayLength; i++)
            {
                solution1 += i < charArray1.Length ? (charArray1[i] - 48) * lineWorth : 0; //-48 wegen Ascii Tabelle
                solution2 += i < charArray2.Length ? (charArray2[i] - 48) * lineWorth : 0; //-48 wegen Ascii Tabelle

                lineWorth *= 2;
            }

            return solution1 / solution2;
        }
        public int BinaryRemainder()
        {
            return solution1 % solution2;
        }
    }
}
