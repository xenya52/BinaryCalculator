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

                Console.WriteLine("Wanna add a binary number?");
                Console.WriteLine("Than just write it :) ...");
                Console.WriteLine("Wanna execute the calculation?");
                Console.WriteLine("Oki than press [x] and enter");
                Console.WriteLine("Just wanna leave?");
                Console.WriteLine("Press [y] and enter");
                string _navigator = Convert.ToString(Console.ReadLine());

                Console.Clear();

                if (_navigator == "x")
                {

                }
                else if (_navigator == "y")
                {
                    return;
                }
                else 
                {
                    Addition.AddBinaryAdditionValues(_navigator);
                }
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