using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public static void ReadInput( int number)
        {

            int count = 0;
          
            for (int i = 1; i <= number; i++)
            { 
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                    Console.WriteLine(number + " is a Prime number");
            }
            else
            {
                Console.WriteLine(number + " is not a Prime number");
            }
            Console.ReadLine();
        }
    }
}
    
