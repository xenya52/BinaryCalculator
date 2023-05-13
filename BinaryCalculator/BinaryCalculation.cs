using System.Diagnostics.Metrics;

namespace BinaryCalculator;
 
/*
 * Example
 * (110100101)₂ = (1 × 2⁸) + (1 × 2⁷) + (0 × 2⁶) + (1 × 2⁵) + (0 × 2⁴) + (0 × 2³) + (1 × 2²) + (0 × 2¹) + (1 × 2⁰) = (421)₁₀
 */
public class BinaryCalculation : UserInput
{
    public int solutionOutput { get; set; } = 0;

    //Calculation method from binary to normal number
    public void CalculationMethod(string userBinaryInput)
    {

        char[] charArray = userBinaryInput.ToCharArray();
        Array.Reverse(charArray);

        int lineWorth = 1;

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
        }
    }
}