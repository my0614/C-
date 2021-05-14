using System;

namespace lamda
{
    class Program
    {
        delegate string Concat(string[] args);
        static void Main(string[] args)
        {
            Concat concat = 
            (arr) =>
            {
                string result = "";
                foreach (string s in arr)
                    result += s;
                return result;
            };

            Console.WriteLine("{0}", concat(args));
            Console.WriteLine("Hello World!");
        }
    }
}
