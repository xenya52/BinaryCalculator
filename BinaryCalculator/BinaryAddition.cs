using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    public class BinaryAddition
    {
        public void BinaryAdditionMethod(string _userBinaryInput1, string _userBinaryInput2)
        {

            char[] charArray1 = _userBinaryInput1.ToCharArray();
            Array.Reverse(charArray1);
            char[] charArray2 = _userBinaryInput2.ToCharArray();
            Array.Reverse(charArray2);

            /*int lineWorth = 1; //!!!!!! */

            int übertrag = 0;

            /*int[] SolutionArray = new int[userBinaryInput.Length]; //?????? */

        }
    }
}
