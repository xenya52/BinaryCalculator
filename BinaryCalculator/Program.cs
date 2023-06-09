using System;
using static System.Net.Mime.MediaTypeNames;

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
            Console.WriteLine("Suptract [4]");
            Console.WriteLine("Multiply [5]");
            Console.WriteLine("Divide + Remainder [6]");
            Console.WriteLine("Just Laura [7] kekw");
            navigator = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();

            if (navigator == 1)
            {
                BinaryConvertInDecimal test1 = new();

                Console.WriteLine("Write");
                string userBinaryInput = Convert.ToString(Console.ReadLine());

                Console.WriteLine(test1.ConvertMethod(userBinaryInput));
                Console.WriteLine("Press any button to continure");
                Console.ReadKey();

                Console.Clear();
            }
            else if (navigator == 2)
            {
                BinaryAddition Addition = new();

                Console.WriteLine("Pls add the first binary number");
                string Binary1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Now enter the second binary number");
                string Binary2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine(Addition.BinaryAdditionMethod(Binary1, Binary2));
                Console.WriteLine("Press any button to continure");
                Console.ReadKey();

                Console.Clear();
            }

            else if (navigator == 3)
            {
                check = false;
            }

            else if (navigator == 4)
            {
                BinarySuptraction Suptraction = new();

                Console.WriteLine("Pls add the first binary number");
                string Binary1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Now enter the second binary number");
                string Binary2 = Convert.ToString(Console.ReadLine());

                Console.WriteLine(Suptraction.BinarySuptractionMethod(Binary1, Binary2));
                Console.WriteLine("Press any button to continure");
                Console.ReadKey();

                Console.Clear();
            }
            else if (navigator == 5)
            {
                BinaryMultiplicationLaura Multiplication = new();

                Console.WriteLine("Pls add the first binary number");
                string Binary1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Now enter the second binary number");
                string Binary2 = Convert.ToString(Console.ReadLine());

                Console.WriteLine(Multiplication.BinaryMultiplicationMethod(Binary1, Binary2));
                Console.WriteLine("Press any button to continure");
                Console.ReadKey();

                Console.Clear();
            }

            else if (navigator == 6)
            {
                BinaryDivide Divide = new();

                Console.WriteLine("Pls add the first binary number");
                string Binary1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Now enter the second binary number");
                string Binary2 = Convert.ToString(Console.ReadLine());

                Console.WriteLine(Divide.BinaryDivideMethod(Binary1, Binary2));
                Console.WriteLine(Divide.BinaryRemainder()); //._.
                Console.WriteLine("Press any button to continure");
                Console.ReadKey();

                Console.Clear();
            }

            else if (navigator == 7) //Lauras süßes rumgewisse
            {

                Console.WriteLine("Pls add the first binary number");
                string Binary1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Now enter the second binary number");
                string Binary2 = Convert.ToString(Console.ReadLine());

                BinaryCalc calc = new(Binary1, Binary2);


                Console.WriteLine(calc.Divide());
                Console.WriteLine(calc.Multiply()); // Q_Q UwU
                Console.WriteLine("Press any button to continure");
                Console.ReadKey();

                Console.Clear();
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