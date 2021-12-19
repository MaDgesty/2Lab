using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
          try
            {
                double x, num, dem, q;
                int i, fakt, z;
                Console.WriteLine("Введите x: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите q: ");
                q = double.Parse(Console.ReadLine());
                num = x * x;
                fakt = 2;
                dem = 1;
                i = 2;
                z = -1;
                int N = 1;
                while (num / fakt >= q)
                {
                    dem = dem + z * num / fakt;
                    i += 2;
                    num = num * x * x;
                    fakt = fakt * (i - 1) * i;
                    z = z * (-1);
                    N = N + 1;
                }
                Console.WriteLine("Количество слагаемых =  " + N);
                Console.WriteLine("Значение cos(x) " + (dem));
                double res = num / fakt;
                Console.WriteLine("x= " + Math.Cos(res));
                Console.ReadKey();

            }
            catch 
            {
                Console.WriteLine(" Вы ввели некорректное значение ");
            }
        }
    }
}
