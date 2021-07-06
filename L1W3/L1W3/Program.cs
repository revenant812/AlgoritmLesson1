using System;

namespace L1W3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cycle(); //вычисление циклически
            //Rec(); //вычисление рекурсивно          
        }     

        static void Cycle()
        {
            //Асимптотическая сложность цикла O(3*N)
            Console.Write("Какой элемент числа Фибоначчи Вы хотите вычислить: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("0");
            long x = 1;
            long y = 0;
            for (int i = 1; i <= (n - 1); i++) //O(N)
            {

                if (x == 1 && y == 0)
                {
                    Console.WriteLine(x);
                }

                long result = x + y; //O(1)
                Console.WriteLine(result);
                y = x; //O(1)
                x = result; //O(1)           
            }
        }

        static int Foo(int n)
        {
            
            if (n < 2)
            {
                return n;
            }
            
            n = Foo(n - 1) + Foo(n - 2);
            
            return n;
            
        }

        static void Rec()
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                Console.WriteLine(Foo(i));
            }        
        }
    }
}

/*


    Foo(2) 
    Foo(1) + Foo(0) = 1 + 0

    Foo(3)
    Foo(2) + Foo(1) = 1 + 1

    Foo(4) 
    Foo(3) + Foo(2) = 2 + 1

    Foo(5)
    Foo(4) + Foo(3) = 2 + 3

    Foo(6)
    FOo(5) + Foo(4) = 5 + 3

 
*/
