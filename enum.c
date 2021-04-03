using System;

namespace overload
{
    class Program
    {
        enum value { I = 13, Love=33, you = 333};
        static void Main(string[] args)
        {

            Console.WriteLine((int)value.I); //  enum의 인덱스번호
            Console.WriteLine(value.I); // enum값
            
 
        }
    }
}
