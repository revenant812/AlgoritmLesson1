using System;

namespace L1W1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d = 0;            
            for(int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    d++;
                }

            }
            if(d == 0)
            {
                Console.WriteLine("Число простое");            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            
        }
    }
}
