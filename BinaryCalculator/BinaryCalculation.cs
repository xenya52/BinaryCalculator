namespace BinaryCalculator;

public class BinaryCalculation : UserInput
{

    public void CalculationMethod()
    {
        char[] CharArray = userBinaryInput.ToString().ToCharArray();
        int count = 0;
        for (int i = 0; i < userBinaryInput.Length; i++)
        {
            if ((userBinaryInput[i] >= '0') && (userBinaryInput[i] <= '9'))
            {
                count++;
            }
        }
    }
    
}