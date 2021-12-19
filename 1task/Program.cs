using System;

namespace _1_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a = ");
                double a = Convert.ToInt32(Console.ReadLine());

                Console.Write("b = ");
                double b = Convert.ToInt32(Console.ReadLine());

                Console.Write("c = ");
                double c = Convert.ToInt32(Console.ReadLine());

                double D = Math.Pow(b, 2) - 4 * a * c;

                Console.WriteLine("D = " + D);



                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("x_1 =" + x1);
                    Console.WriteLine("x_2" + x2);

                }
                else if (D == 0)
                {
                    double x1 = -b / 2 * a;
                    Console.WriteLine("x_1 =" + x1);

                }
                else if (D < 0)
                {

                    double x = -b / 2 * a;
                    double y = (Math.Sqrt(Math.Abs(D)) / 2 * a);
                    Console.WriteLine("Результат:");
                    Console.WriteLine("x_1 = " + x + " + " + "i * " + y);
                    Console.WriteLine("x_2 = " + x + " - " + "i * " + y);

                }

                Console.ReadKey();
            }
            catch 
            {
                Console.WriteLine(" Вы ввели некорректное значение ");
            }
             


            
        }

    }
}