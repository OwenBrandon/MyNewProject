using System;

namespace Calculator
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Console Calculator");

            Console.WriteLine("============================================");

            Console.WriteLine("Press 1 For Addition");
            Console.WriteLine("Press 2 For Subtraction");
            Console.WriteLine("Press 3 For Multiplication");
            Console.WriteLine("Press 4 For Division");

            int action = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1st Number");

            double number_1 = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("Enter 2nd Number");

            double number_2 = Convert.ToInt32((Console.ReadLine()));

            double result = 0;

            switch(action)
            {
                case 1:
                    result = number_1 + number_2;
                    break;

                case 2:
                    result = number_1 - number_2;
                    break;

                case 3:
                    result = number_1 * number_2;
                    break;

                case 4:
                    result = number_1 / number_2;
                    break;

                default:
                    Console.WriteLine("Wrong Input!!");
                    break;
            }

            Console.WriteLine("The result is = {0}", result);
        }
    }
}