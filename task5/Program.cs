using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double  i, j, k, s;
                Console.Write(" Введите число n = ");
                int n = Convert.ToInt32(Console.ReadLine());
                int l = 0;
                for (i = 0; i <= n; i++)
                {
                    for (j = 0; j <= n; j++)
                    {
                        for (k = 0; k <= n; k++)
                        {
                            s = (Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(k, 3));
                            if (s == n)
                            {
                                Console.WriteLine(" х^3 + y^3 + z^3 = n ");
                                Console.WriteLine(" x = " + i);
                                Console.WriteLine(" y = " + j);
                                Console.WriteLine(" z = " + k);
                                l++;
                            }


                        }
                    }
                }
                if (l == 0)
                {
                    Console.WriteLine("No such combinations!");
                }
            }
            catch
            {
                Console.WriteLine(" Вы ввели некорректное значение ");
            }
        }
    }
}
