using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose program number. which program need to execute");
            Console.WriteLine("1:FibonacciSeries\n 2:PerfectNumber\n 3:PrimeNumber\n 4:ReverseNumber\n 5:CouponNumber");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter the number");
                    int fibonacci = Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries.ReadInput(fibonacci);
                    break;
                case 2:
                    Console.WriteLine("Please enter the number");
                    int perfect = Convert.ToInt32(Console.ReadLine());
                    PerfectNumber.ReadInput(perfect);
                    break;
                case 3:
                    Console.WriteLine("Please enter the number");
                    int prime = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.ReadInput(prime);
                    break;
                case 4:
                    Console.WriteLine("Please enter the number");
                    int reverse = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.ReadInput(reverse);
                    break;
                case 5:
                    
                    CouponNumber.DistinctCouponNumber();
                    break;

                default:

                    Console.WriteLine("please select number from the given options");
                    break;
            }
            Console.ReadLine();
        }
    }
}
