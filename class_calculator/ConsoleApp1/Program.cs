using MyExtension;
using System;
using System.Data.Common;

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Fecto(this int myInt)
        {
            int value = myInt;
            int result = 1;
            for (int i = myInt; i >= 1; i--)
                result *= i;

            return result;
        }
        public static int Perma(this int myInt, int exponent)
        {
            int value = myInt;
            int result = 1;
            for (int i = myInt; i >= (value - exponent + 1); i--)
                result *= i;
                
            return result;
        }

    }
}

    namespace ExtensionMethod
    {
        class Mainapp
        {   
            
            static void Main(string[] args)
            {
            int a = 5, b = 3;
            Console.WriteLine("{0}! = {1}", a,a.Fecto());
            Console.WriteLine("{0}P{1} = {2}",a,b, a.Perma(b));

        }
        }
        
    }
