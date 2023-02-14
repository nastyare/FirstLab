using System;

namespace task1
{
    class task1
    {
        static void Main(string[] args)
        {
            Console.Write("Число = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Степень = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int resultOfCalculating = 1;

            for (int indexOfNumber = 0; indexOfNumber < n; ++indexOfNumber)
            {
                resultOfCalculating *= a;
            }

            Console.WriteLine(a + "^" + n + " = " + resultOfCalculating);
            Console.ReadKey();
        }
    }
}

