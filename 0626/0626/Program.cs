using System;
using System.Runtime.InteropServices;

namespace _0626
{
    class Program
    {
        static void Main(string[] args)
        {
            
            static void func(int a, int b)
            {
                int[] array = new int[] { a, b };
                
                Array.Sort(array);
                for(int i=0;i<2;i++)
                {
                    Console.Write(array[i]);
                }
                Console.WriteLine();
            }
            static void func1(int a, int b,int c)
            {
                int[] array = new int[] { a, b,c };
                Array.Sort(array);
                for (int i = 2; i >=0 ; i--)
                {
                    Console.Write(array[i]);
                }
                Console.WriteLine();
            }
            static void func2(int a, int b,int c, int d)
            {
                int[] array = new int[] { a, b ,c,d};

                Array.Sort(array);
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(array[i]);
                    
                }
                Console.WriteLine();
            }

            func(3, 6);
            func1(9, 6, 3);
            func2(1, 3, 4, 8);
            

        }
    }
}
