namespace BinaryCalculator;

public class BinaryCalculation : UserInput
{
    public int solutionOutput { get; set; } = 0;
    
    //Calculation method from binary to normal number
    public void CalculationMethod(string userBinaryInput)
    {
        
        char[] charArray = userBinaryInput.ToString().ToCharArray();
        int count = 1;
        int[] SolutionArray = new int[userBinaryInput.Length];
        
        Array.Reverse(charArray);

        for (int i = 0; i < userBinaryInput.Length; i++)
        {
            count = count * 2; 
            SolutionArray = charArray.Select(_chararray => _chararray - '0').ToArray();                    
            solutionOutput += charArray[i];
        }

    }
}