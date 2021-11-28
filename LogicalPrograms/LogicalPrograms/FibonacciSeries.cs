using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        public static void ReadInput(int number)
        {
            int first = 0;
            int second = 1;
            int third = 0;
            
            if (number <= 1)
            {
                Console.WriteLine(first);
                return;
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 2; i < number; i++)
            {
                third = first + second;
                first = second;
                second = third;
                Console.WriteLine(third);
            }
            Console.ReadLine();
        }
    }
}
      