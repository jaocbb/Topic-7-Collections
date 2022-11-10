using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Topic_7_Collections
{

   internal class Program
    {
        static void Main(string[] args)
        {

            //int choice = 0,remnum,addnum;
            //Console.WriteLine("Here are the numbers I chose for you");
            //List<int> nums = new List<int>{ 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 19, 18, 12, 16, 15, 14, 13, 12, 11, 15, 14 };
            //var number = String.Join(",", nums);
            //Console.Write(number);
            //Console.WriteLine();
            //Console.WriteLine("Click 1 to sort them from least to greatest.");
            //Console.WriteLine("Click 2 to have a new list of numbers.");
            //Console.WriteLine("Click 3 to Remove a number(by value)");
            //Console.WriteLine("CLick 4 to add a value");
            //Console.WriteLine("Click 5 to count the number of occurrences of a specified number"); 
            //Console.WriteLine("CLick 6 to Print the largest number");
            //Console.WriteLine("Click 7 to print the smallest value");
            //Console.WriteLine("Click 8 to quit");
            //choice = Convert.ToInt32(Console.ReadLine());
            //if (choice == 1) 
            //{
            //    nums.Sort();
            //    number = String.Join(",", nums);
            //    Console.WriteLine(number);
            //}
            //if (choice == 2) 
            //{
            //    int[] Newnums = { 20,19,19,18,18,17,18,19,10,10,10,15,14,12,17,16,17,18,19,20,10,11,12,13,14,15 };
            //    var Newnumbers = String.Join(",", Newnums);
            //    Console.WriteLine(Newnumbers);
            //}
            //if (choice == 3)
            //{
            //    Console.WriteLine("Which number would you like to remove");
            //    remnum = Convert.ToInt32(Console.ReadLine());
            //    nums.Remove(remnum);
            //    number = String.Join(",", nums);
            //    Console.WriteLine(number);

            //}
            //if (choice == 4) 
            //{
            //    Console.WriteLine("Which number would you like to add");
            //    addnum = Convert.ToInt32(Console.ReadLine());
            //    nums.Add(addnum);
            //    number = String.Join(",", nums);
            //    Console.WriteLine(number);

            //}
            //if (choice == 5) 
            //{

            //    Console.WriteLine("Here are the numbers occurrences");
            //    var count = new List<int>() { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 19, 18, 12, 16, 15, 14, 13, 12, 11, 15, 14 };
            //    var g = count.GroupBy(i => i);
            //    foreach (var grp in g)
            //    {
            //        Console.WriteLine("{0} {1}",grp.Key,grp.Count());
            //    }

            //}
            //if (choice == 6) 
            //{
            //    Console.Write("The largest number is :");
            //    int[] numbers = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 19, 18, 12, 16, 15, 14, 13, 12, 11, 15, 14 };
            //    int largestNumber = numbers.Max();
            //    Console.WriteLine(largestNumber);
            //    Console.ReadLine();
            //}
            //if (choice == 7) 
            //{
            //    Console.WriteLine("The smallest number is :");
            //    int[] numbers = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 19, 18, 12, 16, 15, 14, 13, 12, 11, 15, 14 };
            //    int smallestNumber = numbers.Min();
            //    Console.WriteLine(smallestNumber);
            //    Console.ReadLine();
            //}
            //if (choice == 8) 
            //{

            //    Console.WriteLine("Closing");
            //    Environment.Exit(0);

            //    Console.WriteLine(); 

            //}
            string choice; 
            Console.WriteLine("Part 2");
            List<string> vegetables = new List<string>();
            vegetables.Add("Carrot");
            vegetables.Add("Beet");
            vegetables.Add("celery");
            vegetables.Add("Radish");
            vegetables.Add("Cabbage");
            for (int i = 0; i < vegetables.Count; i++)
            {
                Console.WriteLine(vegetables[i]);
            }
            Console.WriteLine("Click 1 to remove a vegetable by index");
            Console.WriteLine("Click 2 to remove a vegetable by value");
            Console.WriteLine("CLick 3 to serch for a vegetable");
            Console.WriteLine("CLick 4 to add a vegetable");
            Console.WriteLine("Click 5 to sort the list");
            Console.WriteLine("Click 6 to clear the list");
            if (choice == 1) 
            {
                
            }






            Console.ReadLine();


        }




    }
}
