using System;

namespace LearningCSharpProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number.");

            float xval = 0f;
            float yval = 0f;
            string op = "+";

            try
            {
                xval = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the operator (+ - * /)");
                op = Console.ReadLine();
                Console.WriteLine("Please enter the second number.");
                yval = float.Parse(Console.ReadLine());

                switch (op)
                {
                    case "+":
                        Console.WriteLine("Result: " + summate(xval, yval));
                        break;
                    case "-":
                        Console.WriteLine("Result: " + subtract(xval, yval));
                        break;
                    case "/":
                        Console.WriteLine("Result: " + divide(xval, yval));
                        break;
                    case "*":
                        Console.WriteLine("Result: " + multiply(xval, yval));
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static float multiply(float a, float b)
        {
            float value = 0f;

            try
            {
                value = a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return value;
        }

        public static float subtract(float a, float b)
        {
            float value = 0f;

            try
            {
                value = a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return value;
        }
        public static float summate(float a, float b)
        {
            float value = 0f;

            try
            {
                value = a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return value;
        }
        public static float divide(float a, float b)
        {
            float value = 0f;

            try
            {
                value = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return value;
        }
    }
}
