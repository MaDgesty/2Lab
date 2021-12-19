using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 1;
            int result = 0;
            while (result < 9999)
            {
                result = first + second;

                first = second;

                second = result;
                if (result > 1000 & result < 9999)
                {
                    Console.Write($"{result}");
                }
            }
        }
    
    }
}
