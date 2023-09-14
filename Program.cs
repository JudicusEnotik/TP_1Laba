using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_1lab_Librarry;

namespace TP_1Laba
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите задание (1-4):");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите число n:");
                        int n = int.Parse(Console.ReadLine());
                        long factorial = MathFunctions.CalculateFactorial(n);
                        Console.WriteLine($"Факториал числа {n} равен {factorial}.");
                        break;

                    case 2:
                        Console.WriteLine("Введите значение x для расчета функции:");
                        double x = double.Parse(Console.ReadLine());
                        double result = MathFunctions.CalculateFunction(x);
                        Console.WriteLine($"Значение функции для x = {x} равно {result}.");
                        break;

                    case 3:
                        Console.WriteLine("Введите количество чисел Фибоначчи (n):");
                        int fibonacciCount = int.Parse(Console.ReadLine());
                        int[] fibonacciNumbers = MathFunctions.GenerateFibonacciNumbers(fibonacciCount);
                        Console.WriteLine($"Последовательность чисел Фибоначчи: {string.Join(", ", fibonacciNumbers)}");
                        break;

                    case 4:
                        double z;

                        Console.Write("Введите значение x: ");
                        z = double.Parse(Console.ReadLine());

                            Console.WriteLine("Аппроксимация ln(1+x) с использованием ряда Тейлора:");
                            Console.WriteLine("Период\t\tЗначение");

                            for (int g = 1; g <= 10; g++)
                            {
                                double taylorSeriesApproximation = MathFunctions.CalculateLnTaylorSeries(z, g);
                                Console.WriteLine($"{g}\t\t{taylorSeriesApproximation}");
                            }

                        break;
                

                      default:
                        Console.WriteLine("Некорректный выбор задания.");
                        break;
                }
            }
        }
    }
}
