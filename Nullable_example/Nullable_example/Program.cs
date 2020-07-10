using System;

namespace Nullable_example
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var a = 15;
            var b = "I love you";
            var c = 3.14;
            var arr = new int[] { 10, 20, 30 }; // new는 동적할당 
            Console.WriteLine("type : {0}, value : {1}", a.GetType(), a);
            Console.WriteLine("type : {0}, value : {1}", b.GetType(), b);
            foreach (var i in arr)
                Console.WriteLine("{0}", i);
        }
    }
}
