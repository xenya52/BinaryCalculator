using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    public class BinaryAddition
    {


        public void BinaryAdditionMethod(string userBinaryInput1, string userBinaryInput2)
        {
            
            char[] charArray1 = userBinaryInput1.ToCharArray();
            Array.Reverse(charArray1);
            char[] charArray2 = userBinaryInput2.ToCharArray();
            Array.Reverse(charArray2);

            /*int lineWorth = 1;

            int[] SolutionArray = new int[userBinaryInput.Length];

            for (int i = 0; i < userBinaryInput.Length; i++)
            {
                SolutionArray[i] = charArray[i] - 48; //-48 wegen Ascii Tabelle
                SolutionArray[i] *= lineWorth;
            
                lineWorth *= 2;
            }

            for (int x = 0; x <SolutionArray.Length; x++)
            {
                solutionOutput += SolutionArray[x];
            }*/
        }
    }
}
