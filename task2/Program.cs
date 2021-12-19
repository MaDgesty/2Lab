using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ввведите количество слагаемых: ");
                int terms = Convert.ToInt32(Console.ReadLine());
                int x = 1;
                double PI = 0;
                int m = 1;
                for (int i = 1; i <= terms; i++)
                {
                    if (x == 1)
                    {
                        PI = PI + 1.0 / m;
                    }
                    else
                    {
                        PI = PI - 1.0 / m;
                    }
                    x = -1 * x;
                    m = m + 2;
                }
                Console.WriteLine("Число пи = " + (PI * 4));
            }
            catch
            {
                Console.WriteLine(" Вы ввели некорректное значение ");
            }
        }
    }
}
