using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    internal class BinaryMultiplication
    {
        public int BinaryMultiplicationMethod(string Binary1, string Binary2)
        {
            char[] charArray1 = Binary1.ToCharArray();
            Array.Reverse(charArray1);
            char[] charArray2 = Binary2.ToCharArray();
            Array.Reverse(charArray2);

            int lineWorth = 1; //Gilt für beide

            int arrayLength = charArray1.Length > charArray2.Length ? charArray1.Length : charArray2.Length;


            int[] SolutionArray1 = new int[arrayLength];
            int[] SolutionArray2 = new int[arrayLength];

            int solutionOutput = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                SolutionArray1[i] = i < charArray1.Length ? (charArray1[i] - 48) * lineWorth : 0; //-48 wegen Ascii Tabelle
                SolutionArray2[i] = i < charArray2.Length ? (charArray2[i] - 48) * lineWorth : 0; //-48 wegen Ascii Tabelle

                lineWorth *= 2;
            }

            for (int x = 0; x < arrayLength; x++)
            {
                solutionOutput = SolutionArray1[x] * SolutionArray2[x];
            }
            return solutionOutput;
        }
    }
}
