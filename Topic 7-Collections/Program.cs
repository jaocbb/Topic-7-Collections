using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_7_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0,removeNum;
            Console.WriteLine("Here are the numbers I chose for you. ");
            int[] nums = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 19, 18, 12, 16, 15, 14, 13, 12, 11, 15, 14 };
            var number = String.Join(",", nums);
            Console.Write(number);
            Console.WriteLine();
            Console.WriteLine("Click 1 to sort them from least to greatest.");
            Console.WriteLine("Click 2 to have a new list of numbers.");
            Console.WriteLine("Click 3 to Remove a number(by value)");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1) 
            {
                Array.Sort(nums);
                number = String.Join(",", nums);
                Console.WriteLine(number);
            }
            if (choice == 2) 
            {
                int[] Newnums = { 20,19,19,18,18,17,18,19,10,10,10,15,14,12,17,16,17,18,19,20,10,11,12,13,14,15 };
                var Newnumbers = String.Join(",", Newnums);
                Console.WriteLine(Newnumbers);
            }
            if (choice == 3) 
            {
                Console.WriteLine("Which number would you like to remove");
                removeNum = Convert.ToInt32(Console.ReadLine());
                string strNumbers = " 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 19, 18, 12, 16, 15, 14, 13, 12, 11, 15, 14";
                ArrayList numbers = new ArrayList(strNumbers.Split(new char[] { ',' }));
                numbers.RemoveAt(numbers.IndexOf(10));

            }
            Console.ReadLine();
        
        
        
        }



            
    }
}
