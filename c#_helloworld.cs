using System;
using static System.Console;


namespace helloworld
{
    class hello
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("사용법 : hello.exe <이름>");
                return;
            }

            WriteLine("hello {0}", args[0]);
        }
    }
}
