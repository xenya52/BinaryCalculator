using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    internal class BinaryCalc
    {
        public int a { get; set; }
        public int b { get; set; }

        public BinaryCalc (String a, String b) {
            this.a = Convert.ToInt32(a, 2);
            this.b = Convert.ToInt32(b, 2);
        }

        public int Divide()
        {
            return a / b;
        }
        public int Remainder()
        {
            return a % b;
        }
        public int Multiply()
        {
            return a * b;
        }
       
    }
}
