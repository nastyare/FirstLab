/*******************************
* Рексиус Анастасия Никитовна  *
* ПИ-221                       *
* 1 лабораторная               *
********************************/

using System;

namespace task2
{
    class task2
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");

            int x = Convert.ToInt32(Console.ReadLine());
            int convertedVariable = x;

            do
            {
                convertedVariable = convertedVariable / 10;
                if (convertedVariable < 100)
                {
                    do
                    {
                        convertedVariable = convertedVariable - 10;
                    } while (convertedVariable > 10);
                }
            } while (convertedVariable > 100);

            int n = int.Parse(x.ToString().Remove(1, 1) + convertedVariable);

            Console.WriteLine("Результат: " + n);
        }
    }
}
