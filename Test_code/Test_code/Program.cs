using System;

namespace Test_code
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int lengh = int.Parse(args[0]); #int.Parse -> 자료형변환
            for (int i = 1; i <= lengh; i++)
            {
                Console.WriteLine("hello, {0}", args[i]);
            }
            
        }
    }
}
