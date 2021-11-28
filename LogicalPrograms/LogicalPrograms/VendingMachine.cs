using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class VendingMachine
    {
        public static void FindMinimumNotes()
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] notesCount = new int[notes.Length];
           
            Console.WriteLine("Please enter an amount in Rs to return change from vending machine");
            int amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < notes.Length; i++)
            {
                //25rs
                if (amount >= notes[i])
                {
                    notesCount[i] = amount / notes[i]; //2
                    amount = amount - (notesCount[i] * notes[i]);
                    //amount 5
                  
                }
            }
            for (int i = 0; i < notes.Length; i++)
            {
                if (notesCount[i] != 0)
                {
                    Console.WriteLine("Number of " + notes[i] + "rs note: " + notesCount[i]);


                }
            }

            Console.ReadLine();
        }

    }
}
