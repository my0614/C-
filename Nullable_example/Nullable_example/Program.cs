using System;

namespace Nullable_example
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int? a = null;
             // Console.WriteLine(a.Value); // 값이 없어서 오류
            Console.WriteLine(a.HasValue);
            a = 33;
            Console.WriteLine(a != null);
            Console.WriteLine(a.HasValue);
        }
    }
}
