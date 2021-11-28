using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public static void ReadInput(int number)
        {
            int revNum = 0;
            int rem;
          
            while (number > 0)
            {
                rem = number % 10;
                revNum = revNum * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine("The Reversed num is : " + revNum);
            Console.ReadLine();
        }
    }
}

