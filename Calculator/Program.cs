using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, solve;
            string action;
            Console.WriteLine("Добро пожаловать в Калькулятор!");
            Console.WriteLine("(Возможные операции: \"*\" - умножение, \"/\" - деление, \"+\" - сложение, " +
                "\"-\" - вычитание, " + "\n" + "\"^\" - возведение первого числа в степень второго)");
            Console.WriteLine("Введите первое число:");
            first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберете действие, которое хотите произвести над введеными значениями:");
            action = Console.ReadLine();
            if (action.Length > 1)
            {
                Console.WriteLine("Выбрана несуществующая операция!");
            }
            else
            {
               
                switch (action)
                {
                    case "*":
                        solve = first * second;
                        Console.WriteLine("Ответ: " + first + " * " + second + " = " + solve);
                        break;
                    case "/":
                        solve = first / second;
                        if (second == 0)
                        {
                            Console.WriteLine("Делить на ноль нельзя!");
                        }
                        else
                        {
                            Console.WriteLine("Ответ: " + first + " / " + second + " = " + solve);
                        }
                        break;
                    case "+":
                        solve = first + second;
                        Console.WriteLine("Ответ: " + first + " + " + second + " = " + solve);
                        break;
                    case "-":
                        solve = first - second;
                        Console.WriteLine("Ответ: " + first + " - " + second + " = " + solve);
                        break;
                    case "^":
                        solve = Math.Pow(first, second);
                        Console.WriteLine("Ответ: " + first + " ^ " + second + " = " + solve);
                        break;
                    default:
                        Console.WriteLine("Выбрана несуществующая операция!");
                        break;

                }
            }

        }
    }
}

