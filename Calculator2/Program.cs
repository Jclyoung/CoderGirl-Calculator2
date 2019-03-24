using System;

namespace Calculator2
{
    public static class Program
    {
        public static void Main()
        {
            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 
            /// Ask the first number user would like to use
            /// proceed to convert into a usable double
            Console.WriteLine("Please enter your first number:");
            string firstNumberInput = Console.ReadLine();
            firstNumberInput = firstNumberInput.Trim();
            double firstNumber;
            if (!double.TryParse(firstNumberInput, out firstNumber))
                Console.WriteLine($"The value {firstNumberInput} is not a valid number.");

            Console.WriteLine("Please enter your second number:");
            string secondNumberInput = Console.ReadLine();
            secondNumberInput = secondNumberInput.Trim();
            double secondNumber;
            if (!double.TryParse(secondNumberInput, out secondNumber))
                Console.WriteLine($"The value {secondNumberInput} is not a valid number.");

            Console.WriteLine("Please enter if you would like to add, subtract, multiply or divide: ");
            string operation = Console.ReadLine();

            if (operation == "add")
                Add(firstNumber, secondNumber); /// Method to add 2 user numbers together
            if (operation == "subtract")
                Subtract(firstNumber, secondNumber); /// Method to subtract 2 user numbers
            if (operation == "multiply")
                Multiply(firstNumber, secondNumber); /// Method to multiply 2 user numbers together
            if (operation == "divide")
                Divide(firstNumber, secondNumber); /// Method to divide 2 user numbers
            Console.ReadLine();


            // Use methods for each type of calculation.
            // Create a simple calculator that asks the user to input two different numbers            

            // and whether they want to add, subtract, multiply or divide them. 
        }
        public static double Add(double firstNumber, double secondNumber)
        {
            double answer = 0;
            answer = (firstNumber + secondNumber);
            return answer;
        }

        public static double Subtract(double firstNumber, double secondNumber)
        {
            double answer = 0;
            answer = (firstNumber - secondNumber);
            return answer;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            double answer = 0;
            answer = (firstNumber * secondNumber);
            return answer;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            double answer = 0;
            answer = (firstNumber / secondNumber);
            return answer;
        }
    }
}
