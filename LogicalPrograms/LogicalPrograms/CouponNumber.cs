using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public static void DistinctCouponNumber()
        {
            var chars = "0123456789";
            var stringChars = new char[8];
            var random = new Random();

            int number = 0;
            int n = 1;
         
            Console.WriteLine("Enter the times to generate the coupon");
            number = Convert.ToInt32(Console.ReadLine());

            while (n <= number)
            {

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);
                Console.WriteLine("Coupon number is  " + finalString);
                n++;
            }
            Console.ReadLine();
        }
    }
}    