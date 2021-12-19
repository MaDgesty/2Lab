using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите N: ");
                int N = Convert.ToInt32(Console.ReadLine());
                int D = N % 10;

                if (N >= 1 && N <= 100)
                {
                    if (D == 1)
                    {
                        Console.WriteLine("{0} год", N);
                    }
                    if (D == 2 || D == 3 || D == 4)
                    {
                        Console.WriteLine("{0} года", N);
                    }
                    if (D == 5 || D == 6 || D == 7 || D == 8 || D == 9 || D == 0)
                    {
                        Console.WriteLine("{0} лет", N);
                    }

                }
                else Console.WriteLine("Неправильно введено число");
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректное значение");
            }
        }
    }
}
