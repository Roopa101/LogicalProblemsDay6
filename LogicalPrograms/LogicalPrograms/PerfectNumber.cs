using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public static  void ReadInput(int number)
        {
            int sum = 0;
           
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    Console.WriteLine("{0} ", i);
                }
            }
            if (sum == number)
            {
                Console.WriteLine(number + " is a Perfect number");
            }
            else
            {
                Console.WriteLine(number + " is not a Perfect number");
            }
            Console.ReadLine();
        }
    }
}
       