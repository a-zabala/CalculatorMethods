using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input the numbers 
            Console.WriteLine("This program will work as a calculator");
            Console.Write("Please enter a number: ");
            string firstNum = Console.ReadLine();
            Console.Write("Please enter a second number: ");
            string secondNum = Console.ReadLine();

            //Converts the input to integers
            int valFirst = Convert.ToInt32(firstNum);
            int valSecond = Convert.ToInt32(secondNum);

            //Inputs the desired operation
            Console.Write("What would you like to do to the numbers (+,-,*, /): ");
            string operation = Console.ReadLine();

            //actions to take depending on which operation is chosen
            if (operation == "+")
            {
                //Sends to Add method if + is chosen
                var answer = Add(valFirst, valSecond);
                //Outputs the number sentence and answer using method
               Console.WriteLine(NumSentence(valFirst, operation, valSecond, answer));
            }

            else if (operation == "-")
            {
                //Sends to Subtract method if - is chosen
                var answer = Subtract(valFirst, valSecond);
                //Outputs the number sentence and answer using method
                Console.WriteLine(NumSentence(valFirst, operation, valSecond, answer));
            }

            else if ((operation == "*") || (operation == "x"))
            {
                //Sends to Multiply method if x or * is chosen
                var answer = Multiply(valFirst, valSecond);
                Console.WriteLine(NumSentence(valFirst, operation, valSecond, answer));
            }

            else if ((operation == "/") && (valSecond != 0))
            {
                //Sends to Divide method if / is chosen and 0 is not the second number
                decimal answer = Divide(valFirst, valSecond);
                Console.WriteLine($"{valFirst} {operation} {valSecond}  =  {answer}");
            }

            //Deals with problem of dividing by zero
            else if ((operation == "/") && (valSecond == 0))
            {
                Console.WriteLine("You cannot divide by zero, that is undefined");
            }

            //all other inputs if not recognized
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

        /// <summary>
        /// THis method subtracts two numbers
        /// </summary>
        /// <param name="valFirst"></param>
        /// <param name="valSecond"></param>
        /// <returns> the difference of two numbers</returns>
        private static int Subtract(int valFirst, int valSecond)
        {
            return valFirst - valSecond;
        }

        /// <summary>
        /// this method multipies two numbers
        /// </summary>
        /// <param name="valFirst"></param>
        /// <param name="valSecond"></param>
        /// <returns> product of two numbers</returns>
        private static int Multiply(int valFirst, int valSecond)
        {
            return valFirst * valSecond;
        }
        /// <summary>
        /// THis method divides two numbers
        /// </summary>
        /// <param name="valFirst"></param>
        /// <param name="valSecond"></param>
        /// <returns>quotient of two numbers</returns>
        private static decimal Divide(int valFirst, int valSecond)
        {
            //Converts the integers to decimal so answer can be more precise
            decimal decFirst = Convert.ToDecimal(valFirst);
            decimal decSecond = Convert.ToDecimal(valSecond);
            return decFirst / decSecond;
        }

        /// <summary>
        /// This method outputs the number sentence in all but division
        /// </summary>
        /// <param name="valFirst"></param>
        /// <param name="operation"></param>
        /// <param name="valSecond"></param>
        /// <param name="answer"></param>
        /// <returns>the number sentence</returns>
        private static string NumSentence(int valFirst, string operation, int valSecond, int answer)
        {
            return $"{valFirst} {operation} {valSecond} = {answer}";
        }
       
    }

}