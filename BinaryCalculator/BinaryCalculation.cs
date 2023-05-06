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
        int count = 1;
        int[] SolutionArray = new int[userBinaryInput.Length];

        for (int i = 0; i < userBinaryInput.Length; i++)
        {
            count *= 2; 
            SolutionArray = charArray.Select(_chararray => _chararray - '0').ToArray();
            SolutionArray[i] += count; 
            /*You need to make that it only reactes if you had a one, otherwise he will override zeros...*/
            solutionOutput += SolutionArray[i];
        }

    }
}