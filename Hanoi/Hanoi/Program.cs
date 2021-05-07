using System;
using System.Reflection.Metadata.Ecma335;

namespace Hanoi
{

    class MainApp
    {
        
        static string GetLine(string fileName, double line)
        {
            using (var sr = new System.IO.StreamReader(fileName))
            {
                for (int i = 1; i <= line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }

        static int Main(string[] args)
        {
            int counter = 0;


            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\MY\workspace\C-sharp\interface\interface\bin\Debug\netcoreapp3.1\Hanoi.txt");
            Console.WriteLine("하노이탑의 개수를 적으시오(1~12까지)");
            string num = Console.ReadLine();
            int num2 = int.Parse(num);
           
            int result = 1;

                //file.Close();
                double start, end;
                double line;

                start = Math.Pow(2, num2 ) - 1 - num2;
                end = Math.Pow(2,num2+1)-1-num2-1;
                for (double i = start; i <= end - 1; i++)
                {
                    //Console.WriteLine(i);
                    string txt = MainApp.GetLine(@"C:\Users\MY\workspace\C-sharp\interface\interface\bin\Debug\netcoreapp3.1\Hanoi.txt", i);
                    Console.WriteLine(txt);

                }

            return 0;    
        }
       
    }
}
