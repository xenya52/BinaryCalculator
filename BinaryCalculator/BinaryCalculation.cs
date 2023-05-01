namespace BinaryCalculator;

public class BinaryCalculation : UserInput
{
    public int solutionOutput { get; set; } = 0;
    
    //Calculation method from binary to normal number
    public void CalculationMethod(string userBinaryInput)
    {
        char[] CharArray = userBinaryInput.ToString().ToCharArray();
        int count = 0;

        CharArray.Reverse();

        for (int i = 0; i < userBinaryInput.Length; i++)
        {
            if ((userBinaryInput[i] >= '0') && (userBinaryInput[i] <= '9'))
            {
                count = count * 2;
            }
        }

        for (int i = 0; i < userBinaryInput.Length; i++)
        {
            if (CharArray[i] == '1')
            {
                solutionOutput = solutionOutput + CharArray[i];
            }

        }
    }
}