using System;


namespace Hanoi
{

    class MainApp
    {
        
        static string GetLine(string fileName, double line)
        {
            using (var sr = new System.IO.StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            int counter = 0;
       
            string num = Console.ReadLine();
            int result = 1;
            
           /*
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\MY\workspace\C-sharp\interface\interface\bin\Debug\netcoreapp3.1\Hanoi.txt");
           */

            //file.Close();
            double start, end;
            double line;
            start = Math.Pow(2, int.Parse(num)-int.Parse(num));
            end = Math.Pow(2, int.Parse(num)) - 1;
            Console.WriteLine(start);
            Console.WriteLine(end);
            for(double i=start;i<=end;i++)
            {
                //Console.WriteLine(i);
                 string txt = MainApp.GetLine(@"C:\Users\MY\workspace\C-sharp\interface\interface\bin\Debug\netcoreapp3.1\Hanoi.txt", i);
                Console.WriteLine(txt);
                
                
            }
                
             
                
        }
    }
}
