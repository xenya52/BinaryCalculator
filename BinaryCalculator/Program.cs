using System;

namespace BinaryCalculator;

class Program
{
    public static void Main(string[] args)
    {
        BinaryCalculation test1 = new();
        Console.WriteLine("Write");
        string userBinaryInput = Convert.ToString(Console.ReadLine());
        test1.CalculationMethod(userBinaryInput); 
        Console.WriteLine(test1.solutionOutput);
        Console.ReadKey();
    }
}