using System;

namespace person
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Нажмите 1 для открытия первой личной прграммы и 2 для второй программы! \nВы выбрали: "); int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                    first();
                }
                else if (number == 2)
                {
                    second();
                }
                else if (number < 1 | number > 2)
                {
                    Console.WriteLine("Введите 1 или 2 !");
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели не число!");
            }
        }
        static void second()
        {
            int sum = 1;
            for (int i = 1; i <= 9; i++)
            {
                sum = sum * i;
                Console.Write($"{sum} ");
            }
        }
        static void first()
        {
            Console.Write("Введите первый катет: "); double one = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второй катет: "); double two = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите первую гипотенузу: "); double three = Convert.ToInt32(Console.ReadLine());
            if (one <= 0 | two <= 0 | three <= 0)
            {
                Console.WriteLine("‘Error");
            }
            else if (Math.Pow(three, 2) == Math.Pow(one, 2) + Math.Pow(two, 2))
            {
                Console.WriteLine("true");
            }
            else if (Math.Pow(three, 2) != Math.Pow(one, 2) + Math.Pow(two, 2))
            {
                Console.WriteLine("false");
            }

        }
    }
}