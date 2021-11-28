using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ElapsedTime
    {
        public static void IterateOverLoop()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(100);
            }
            stopwatch.Stop();
            Console.WriteLine("elapse time:{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

    }
}
