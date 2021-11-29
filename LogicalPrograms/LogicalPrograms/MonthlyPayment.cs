using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class MonthlyPayment
    {
        public static void Money()
        {
            Console.WriteLine("Enter the Principal loan : ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Year : ");
            double year = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Rate : ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Monthly Payment is " + monthlyPayment(principal, year, rate));
        }
        public static double monthlyPayment(double P, double Y, double R)
        {
            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = P * r / (1 - Math.Pow((1 + r), -n));
            return payment;
        }
    }
}
      