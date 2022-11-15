using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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

            //int choice = 0, remnum, addnum;
            //Console.WriteLine("Here are the numbers I chose for you");
            //List<int> nums = new List<int> { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 19, 18, 12, 16, 15, 14, 13, 12, 11, 15, 14 };
            //var number = String.Join(",", nums);
            //Console.Write(number);
            //Console.WriteLine();
            //Console.WriteLine("Click 1 to sort them from least to greatest.");
            //Console.WriteLine("Click 2 to have a new list of numbers.");
            //Console.WriteLine("Click 3 to Remove a number(by value)");
            //Console.WriteLine("Click 4 to add a value");
            //Console.WriteLine("Click 5 to count the number of occurrences of a specified number");
            //Console.WriteLine("Click 6 to Print the largest number");
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
            //    int[] Newnums = { 20, 19, 19, 18, 18, 17, 18, 19, 10, 10, 10, 15, 14, 12, 17, 16, 17, 18, 19, 20, 10, 11, 12, 13, 14, 15 };
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
            //        Console.WriteLine("{0} {1}", grp.Key, grp.Count());
            //    }

            //}
            //if (choice == 6)
            //{
            //    Console.Write("The largest number is :");
            //    int[] numbers = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 19, 18, 12, 16, 15, 14, 13, 12, 11, 15, 14 };
            //    int largestNumber = numbers.Max();
            //    Console.Write(largestNumber);
            //    Console.ReadLine();
            //}
            //if (choice == 7)
            //{
            //    Console.WriteLine("The smallest number is :");
            //    int[] numbers = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 19, 18, 12, 16, 15, 14, 13, 12, 11, 15, 14 };
            //    int smallestNumber = numbers.Min();
            //    Console.Write(smallestNumber);
            //    Console.ReadLine();
            //}
            //if (choice == 8)
            //{

            //    Console.WriteLine("Closing");
            //    Environment.Exit(0);

            //    Console.WriteLine();

            //}
            // git wont push
            string choiceveg, remveg, vegserch, newveg;
            Console.WriteLine("Part 2");
            List<string> veglist = new List<string>() { "Carrot,Beet,Celery,Radish,Cabbage" };
            var vegetables = String.Join(",", veglist);
            Console.WriteLine("Heres your list of vegetables");
            Console.WriteLine(vegetables);
            Console.WriteLine("Click 1 to remove a vegetable by index");
            Console.WriteLine("Click 2 to remove a vegetable by value");
            Console.WriteLine("CLick 3 to serch for a vegetable");
            Console.WriteLine("CLick 4 to add a vegetable");
            Console.WriteLine("Click 5 to sort the list by alphabetical order");
            Console.WriteLine("Click 6 to clear the list");
            choiceveg = Convert.ToString(Console.ReadLine());

            //test
            Console.WriteLine("Test");
            if (choiceveg == "1")
            {
                Console.WriteLine("Which vegetable would you like to remove by index.");
                int indexrem = Convert.ToInt32(Console.ReadLine());
                StringCollection vegcol = new StringCollection();
                String[] veglist2 = new String[] { "1,Carrot", "2,Beet", "3,Celery", "4,Raddish", "5,Cabbage" };
                vegcol.AddRange(veglist2);
                foreach (Object obj in vegcol)
                Console.WriteLine(obj);
                vegcol.RemoveAt(indexrem);
                Console.WriteLine("The list should look like this now with your removed vegetable : ");
                foreach (Object obj in vegcol)
                    Console.WriteLine(obj);

            }
            if (choiceveg == "2")
            {
               Console.WriteLine("Which vegetable would you like to remove by value?");
               remveg = Convert.ToString(Console.ReadLine());
               veglist.Remove(remveg);
               vegetables = String.Join(",", veglist);
               Console.WriteLine(vegetables);
            }
            if (choiceveg == "3")
            {
                Console.WriteLine("What vegetable would you like to serch for");
                vegserch = Convert.ToString(Console.ReadLine());
                List<string> veglist2 = new List<string>();
                veglist2.Add("Carrot");
                veglist2.Add("Beet");
                veglist2.Add("Radish");
                veglist2.Add("Cabbage");
                veglist2.Add("Celery");
            }
            if (choiceveg == "4")
            {
                Console.WriteLine("what vegetable would you like to add?");
                newveg = Convert.ToString(Console.ReadLine());
                veglist.Add(newveg);                           //WORKS
                vegetables = String.Join(",", veglist);
                Console.WriteLine(vegetables);
            }
            if (choiceveg == "5")
            {
                List<string> sortveg = new List<string>() { "Carrot", "Beet", "Radish", "Cabbage", "Celery" };
                var sortedList = sortveg.OrderBy(x => x).ToList(); //WORKS
                Console.WriteLine(String.Join(", ", sortedList));
            }
            if (choiceveg == "6")
            {
                veglist.Clear();
            }
          






                Console.ReadLine();


            



        }
    }
}
