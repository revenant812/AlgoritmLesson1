using System;

namespace L1W2
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            //Асимптотическая сложность O(N^3)
            int[] array = new int[10000000];
            Console.WriteLine(StrangeSum(array));                     
        }

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y;                       
                    }
                }
            }
            return sum;
        }
    }
}