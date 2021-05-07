using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;

namespace Interface
{
    interface ILogger
    {
        void WriteLog(string form, int n, char from, char to); // 인자 값 3개
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string form, int n, char from, char to)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t", n, from, to);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;
        
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string form, int n, char from, char to)
        {
            writer.WriteLine("{0}\t{1}\t{2}\t", n, from, to);
        }

    }
    class ClimateMonitor
    {
        int cnt=0;
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void hanoi_tower(int n, char from, char tmp, char to)
        {
            
            if (n == 1)
            {
                Console.WriteLine("{0}\t{1}\t{2}", n, from, to);
                logger.WriteLog("{0}\t{1}\t{2}", n, from, to);
            
            }
            else
            {
                hanoi_tower(n - 1, from, tmp,to);
                Console.WriteLine("{0}\t{1}\t{2}", n, from, to);
                hanoi_tower(n - 1, tmp, to, from);
                logger.WriteLog("{0}\t{1}\t{2}", n, from, to);
            
            }
            
            
        }
     

    }
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor moniter = new ClimateMonitor(new FileLogger("Hanoi.txt"));
   
            for(int i=1;i<13;i++)
                moniter.hanoi_tower(i, 'A', 'B', 'C');
            
            

        }

    }
}