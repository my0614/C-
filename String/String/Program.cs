using System;

namespace String
{
    class Program
    {
        enum{hello, thank, love};
        static void Main(string[] args)
        {
            Console.WriteLine("사격형의 높이를 적으시오\n");
            string  height = Console.ReadLine();
            Console.WriteLine("사각형의 넓이를 적으시오.\n");
            string width = Console.ReadLine();

            Console.WriteLine(" 넓이는 = {0}", Convert.ToInt32(height) * Convert.ToInt32(width));
        }
    }
}
