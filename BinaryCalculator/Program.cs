using System;

namespace BinaryCalculator;

class Program
{
    static public void main(string[] args)
    {
        BinaryCalculation test1 = new();
        test1.CalculationMethod();
        Console.ReadKey();
    }
}