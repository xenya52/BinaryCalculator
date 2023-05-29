using System;

namespace BinaryCalculator;

class Program
{
    public static void Main(string[] args)
    {
        int navigator = 0;
        bool check = true;
        do
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("What do you want to do? (type the number in)");
            Console.WriteLine("Convert a binary into a decimal? [1]");
            Console.WriteLine("Make a binary addition? [2]");
            Console.WriteLine("Leave the program? [3]");
            navigator = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();

            if (navigator == 1)
            {
                BinaryConvertInDecimal test1 = new();

                Console.WriteLine("Write");
                string userBinaryInput = Convert.ToString(Console.ReadLine());

                test1.ConvertMethod(userBinaryInput);

                Console.WriteLine(test1.solutionOutput);
                Console.WriteLine("Press any button to continure");
                Console.ReadKey();

                Console.Clear();
            }
            else if (navigator == 2)
            {
                BinaryAddition Addition = new();

               Console.WriteLine("Write you first number");
               string firstNumber = Convert.ToString(Console.ReadLine());
               Console.WriteLine("Write you second number");
               string secondNumber = Convert.ToString(Console.ReadLine());
               
               Addition.BinaryAdditionMethod(firstNumber, secondNumber);
            }
            else if (navigator == 3)
            {
                check = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("==========================");
                Console.WriteLine("Error: Something went wrong");
                Console.WriteLine("==========================");
                Thread.Sleep(3000);

                Console.Clear();
            }

        } while (check);
    }
}