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
            Console.WriteLine("1:FibonacciSeries\n 2:PerfectNumber\n 3:PrimeNumber\n 4:ReverseNumber\n 5:CouponNumbe \n 6:ElapsedTime\n 7:VendingMachine\n 8:DayOfWeek\n 9:TemperatureConversion \n 10:MonthlyPayment\n 11:SquareRoot\n 12:SwappingNibbles\n");
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

                case 6:
                    ElapsedTime.IterateOverLoop();
                    break;

                case 7:
                    VendingMachine.FindMinimumNotes();
                    break;
                
                case 8:
                    DayOfWeek.DayWeekYear();
                    break;
                
                case 9:
                    TemperatureConversion.Temp();
                    break;
                
                case 10:
                    MonthlyPayment.Money();
                    break;
                
                case 11:
                    SquareRoot.Root();
                    break;
                case 12:
                    SwappingNibbles sw = new SwappingNibbles();
                    int number = sw.swapNibbles(100);

                    Console.WriteLine("After swapping of nibbles: " + number);
                    break;

                default:
                    Console.WriteLine("please select number from the given options");
                    break;
            }
            Console.ReadLine();
        }
    }
}
