using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will work as a calculator");
            Console.Write("Please enter a number: ");
            string firstNum = Console.ReadLine();
            Console.Write("Please enter a second number: ");
            string secondNum = Console.ReadLine();

            int valFirst = Convert.ToInt32(firstNum);
            int valSecond = Convert.ToInt32(secondNum);

            Console.Write("What would you like to do to the numbers (+,-,*, /): ");
            string operation = Console.ReadLine();





            if (operation == "+")
            {
                var answer = Add(valFirst, valSecond);
                Console.WriteLine(valFirst + operation + valSecond + " = " + answer);
            }

            else if (operation == "-")
            {
                var answer = Subtract(valFirst, valSecond);
                Console.WriteLine(valFirst + operation + valSecond + " = " + answer);
            }

            else if ((operation == "*") || (operation == "x"))
            {
                var answer = Multiply(valFirst, valSecond);
            }

            else if ((operation == "/") && (valSecond != 0))
            {
                //var answer = Convert.ToDouble(valFirst / valSecond);
                decimal answer = Divide(valFirst, valSecond);
                Console.WriteLine(valFirst + operation + valSecond + " = " + answer);
            }

            else if ((operation == "/") && (valSecond == 0))
            {
                Console.WriteLine("You cannot divide by zero, that is undefined");
            }

            else
                Console.WriteLine("Your input was not recognized, try again");

            Console.ReadLine();
        }
        /// <summary>
        /// This method adds two numbers
        /// </summary>
        /// <param name="valFirst"></param>
        /// <param name="valSecond"></param>
        /// <returns>the sum of two numbers</returns>
        private static int Add(int valFirst, int valSecond )
        {
            return valFirst + valSecond;
        }

        private static int Subtract(int valFirst, int valSecond)
        {
            return valFirst - valSecond;
        }

        private static int Multiply(int valFirst, int valSecond)
        {
            return valFirst * valSecond;
        }

        private static decimal Divide(int valFirst, int valSecond)
        {
            decimal decFirst = Convert.ToDecimal(valFirst);
            decimal decSecond = Convert.ToDecimal(valSecond);
            decimal answer = decFirst / decSecond;
            Console.WriteLine(answer);
            return answer;
        }

       
    }

}