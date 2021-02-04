using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadQueueAndLock
{
    class Program
    {
        private static void PrintFrom1To10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        private static void PrintHW()
        {
                Console.WriteLine("Hello world");
                Thread.Sleep(2000);
        }
        static void Main(string[] args)
        {
            ThreadExecutor te = new ThreadExecutor();

            te.Add(new Thread(PrintFrom1To10));
            te.Execute();
            te.Add(new Thread(PrintHW));
            te.Execute();
        }


    }
}
