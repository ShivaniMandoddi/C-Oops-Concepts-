using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Array List is a non-generic collection of objects whose size increases dynamically.
             * Array List can be used to add unknown data where we don't types and sizes of data.
             * Array List is included in System.Collections.
             */
            //Examples: 
             ArrayList myArrayList = new ArrayList();  // Declaring an ArrayList with undefined amount of object
            ArrayList myArrayListTwo = new ArrayList(10);// Declaring an ArrayList with defined amount of object
            myArrayList.Add(90); // Add is the method where we can add value to the array
            myArrayList.Add(85);
            myArrayList.Add(60);
            myArrayList.Add("Shivani");
            myArrayList.Add("Parvathi");
            myArrayList.Add("Seeta");
            myArrayList.Add("Sindhu");
            myArrayList.Add(14.05f);
            myArrayList.Add(145.05f);
            myArrayList.Add(12.455f);

            //myArrayList.Remove(90); //Delete element with a specific value from the list
            // Delete a element at specific position 
            //myArrayList.RemoveAt(2);
            Console.WriteLine("Length of Array List :"+myArrayList.Count);
            foreach (var item in myArrayList)
            {
                if(item is string)
                    Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
