using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class SwappingNibbles
    {
        // Function for swapping   
        public int swapNibbles(int x)
        {
            // “x & 0x0F” gives us last 4 bits of x. For x = 100, the result is 00000100.
            // Using bitwise ‘<<‘ operator, we shift the last four bits to the left 4 times and
            // make the new last four bits as 0. The result after shift is 01000000.
            
            // “x & 0xF0” gives us first four bits of x.For x = 100, the result is 01100000.
            // Using bitwise ‘>>’ operator, we shift the digit to the right 4 times and
            // make the first four bits as 0.The result after shift is 00000110.
           
            // For x = 100, the value of(01000000) OR(00000110) gives the result 01000110 which is equal to 70
            // in decimal.
            return ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
        }
    }
}

