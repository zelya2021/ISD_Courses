using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static class Calculator
        {
            public static double Add(double i, double j)
            {
                return i + j;
            }

            public static double Sub(double i, double j)
            {
                return i - j;
            }

            public static double Div(double i, double j)
            {
                return i / j;
            }

            public static double Mul(double i, double j)
            {
                return i * j;
            }
        }
        static void Main(string[] args)
        {
            string op = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Введите операцию (+-/*)\n0-Exit:");
                op = Console.ReadLine();
                double result = 0;
                switch (op)
                {
                    case "+":
                        Operation(op, ref result);
                        Console.WriteLine("Результат операции = " + result);
                        Console.ReadLine();
                        break;
                    case "-":
                        Operation(op, ref result);
                        Console.WriteLine("Результат операции = " + result);
                        Console.ReadLine();
                        break;
                    case "/":
                        Operation(op, ref result);
                        Console.WriteLine("Результат операции = " + result);
                        Console.ReadLine();
                        break;
                    case "*":
                        Operation(op, ref result);
                        Console.WriteLine("Результат операции = " + result);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Введите корректный символ!");
                        break;
                }
            } while (op!="0");
            
        }
        public static void Operation(string op, ref double result)
        {
            try
            {
                Console.WriteLine("Введите первое число:");
                double firstN = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                double secondN = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case "+":
                        result = Calculator.Add(firstN, secondN);
                        break;
                    case "-":
                        result = Calculator.Sub(firstN, secondN);
                        break;
                    case "/":
                        result = Calculator.Div(firstN, secondN);
                        break;
                    case "*":
                        result = Calculator.Mul(firstN, secondN);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Введите число корректно!");
                Operation(op, ref result);
            }
        }
    }
}
