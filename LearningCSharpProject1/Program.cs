using System;
using System.IO;

namespace LearningCSharpProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            //For first run check if log file exists
            if (!File.Exists(Environment.CurrentDirectory + "/log.txt"))
            {
                FileStream filechecker = File.Create(Environment.CurrentDirectory + "/log.txt");
                filechecker.Close();
                filechecker.Dispose();
            }

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "Calculate":
                        Calculate();
                        break;
                    case "LoadLogs":
                        LoadLogs();
                        break;
                    case "DeleteLogs":
                        DeleteLog();
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                    case "Help":
                        Console.WriteLine("Available Commands: Calculate, LoadLogs, DeleteLogs, Exit, Help, LocateLogs");
                        break;
                    case "LocateLogs":
                        Console.WriteLine(Environment.CurrentDirectory + "/log.txt".ToString());
                        break;
                    default:
                        Console.WriteLine("Error, Command does not exist. Use Help for available commands.");
                        break;
                }
            }
        }

        public static void LoadLogs()
        {
            try
            {
                Console.WriteLine(File.ReadAllText(Environment.CurrentDirectory + "/log.txt"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading log file. Stack Trace: " + ex.ToString());
            }
        }

        public static void LogResult(float result, float x, float y, string op)
        {
            try
            {
                File.AppendAllText(Environment.CurrentDirectory + "/log.txt", Environment.NewLine + "X = " + x.ToString() + " Y = " + y.ToString() + " Operation: " + op + " Result: " + result.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing result to log file. Stack Trace: " + ex.ToString());
            }
        }

        public static void DeleteLog()
        {
            if (File.Exists(Environment.CurrentDirectory + "/log.txt"))
            {
                try
                {
                    File.Delete(Environment.CurrentDirectory + "/log.txt");

                    if (!File.Exists(Environment.CurrentDirectory + "/log.txt"))
                    {
                        FileStream filechecker = File.Create(Environment.CurrentDirectory + "/log.txt");
                        filechecker.Close();
                        filechecker.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting log file. Stack Trace: " + ex.ToString());
                }
            }
        }

        public static void Calculate()
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

                float result = DoMath(xval, yval, op);
                Console.WriteLine("Result " + result.ToString());
                LogResult(result, xval, yval, op);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static float DoMath(float x, float y, string op)
        {
            switch (op)
            {
                case "+":
                    return x + y;
                case "-":
                    return x - y;
                case "/":
                    return x / y;
                case "*":
                    return x * y;
                default:
                    return 0f;
            }
        }
    }
}