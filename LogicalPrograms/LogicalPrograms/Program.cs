﻿using System;
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
            Console.WriteLine("1:FibonacciSeries\n ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter the number");
                    int fibonacci = Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries.ReadInput(fibonacci);
                    break;

                default:

                    Console.WriteLine("please select number from the given options");
                    break;
            }
            Console.ReadLine();
        }
    }
}