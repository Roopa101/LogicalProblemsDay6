using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ToBinary
    {
       public static void block(long x)
        {
            List<int> v = new List<int>();

            // Convert decimal number to
            // its binary equivalent
            Console.Write("Blocks for " + x + " : ");

            while (x > 0)
            {
                v.Add((int)x % 2);
                x = x / 2;
            }

            // Displaying the output when
            // the bit is '1' in binary
            // equivalent of number.
            for (int i = 0; i < v.Count; i++)
            {
                if (v[i] == 1)
                {
                    Console.Write(i);

                    if (i != v.Count - 1)
                        Console.Write(" , ");
                }
            }

            Console.WriteLine();
            Console.ReadLine();
        }

    }
}