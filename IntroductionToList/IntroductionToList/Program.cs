using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToList
{
    class Program
    {
        /*Introduction To List
         * Lists are strongly typed objects that can be acessed by index and
         * having methods for sorting,searching,modifying
         * Syntax:
         * List<T> T means specify type of data that can be stored.
         * Ex: 
         * List<int> numbers=new List<int>();
         */
        static void Main(string[] args)
        {
            /*   List<int> numbers = new List<int>();
               numbers.Add(1);
               numbers.Add(2);
               numbers.Add(3);
               numbers.Add(4);

               foreach (var item in numbers)
               {
                   Console.WriteLine(item);
               }
               numbers.Remove(3);
               Console.WriteLine("After removing the number 3");
               foreach (var item in numbers)
               {
                   Console.WriteLine(item);
               }*/
            // Challenge: Create list of names and print out each one
            //When you hit any key need to remove random element from the list and reprint the names
            List<string> names = new List<string>();
            names.Add("Shivani");
            names.Add("Mrudula");
            names.Add("Vyshanvi");
            names.Add("jyosthna");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            var r = new Random();
            int s = r.Next(0,names.Count);
            Console.WriteLine("After removing a random name");
            names.RemoveAt(s);
            
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
