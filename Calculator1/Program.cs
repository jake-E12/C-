using System;

namespace Calculator1
{
    class Program
    {
        public static string calculationOp;
        public static string calculationNum1;
        public static string calculationNum2;
        public static int result;

        static void Add(string num1, string num2)
        {
            result = Int16.Parse(calculationNum1) + Int16.Parse(calculationNum2);
            Console.WriteLine(result);
        }

        static void Takeaway(string num1, string num2)
        {
            result = Int16.Parse(calculationNum1) - Int16.Parse(calculationNum2);
            Console.WriteLine(result);
        }

        static void Divide(string num1, string num2)
        {
            result = Int16.Parse(calculationNum1) / Int16.Parse(calculationNum2);
            Console.WriteLine(result);
        }

        static void Times(string num1, string num2)
        {
            result = Int16.Parse(calculationNum1) * Int16.Parse(calculationNum2);
            Console.WriteLine(result);
        }


        static void Main()
        {
            Console.WriteLine("Enter a calulation operator: ");
            calculationOp = Console.ReadLine();

            Console.WriteLine("Enter your first number: ");
            calculationNum1 = Console.ReadLine();

            Console.WriteLine("Enter your second number: ");
            calculationNum2 = Console.ReadLine();

            if (calculationOp == "+")
            {
                Add(calculationNum1, calculationNum2);
            }

            if (calculationOp == "-")
            {
                Takeaway(calculationNum1, calculationNum2);
            }

            if (calculationOp == "x")
            {
                Times(calculationNum1, calculationNum2);
            }

            if (calculationOp == "/" || calculationOp == @"\")
            {
                Divide(calculationNum1, calculationNum2);
            }

        }
    }
}
