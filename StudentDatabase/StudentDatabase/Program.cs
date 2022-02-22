using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsRecord = true;
           
            Student[] studentRecord = new Student[3];
            /*studentRecord[0] = new Student("Shivani", "Mandoddi", "CSE", 20, 94);
                studentRecord[1] = new Student("Pallavi", "Meriya", "ECE", 22, 85);
                studentRecord[2] = new Student("Ramya", "Dhruvi", "CSE", 19, 92);
                studentRecord[3] = new Student("Shashi", "Dhar", "MECH", 24, 82);
                studentRecord[4] = new Student("Arun", "Maritla", "CSE", 17, 90);
                Console.WriteLine(studentRecord.Length);
                Console.WriteLine("Student Database\n");*/
            int i;
           
            //Console.WriteLine(studentRecord.Length);
            for(i=0;i< studentRecord.Length;i++)
            {
                try 
                {
                    
                    Console.WriteLine("Enter Student No. {0} details: ", i+1);
                    Console.WriteLine("Enter first name");
                    string firstName =Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter last name");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter branch");
                    string branch = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Marks");
                    int marks = Convert.ToInt32(Console.ReadLine());
                    studentRecord[i] = new Student(firstName, lastName, branch,age,marks);
                    Console.Clear();

                }
                
                catch (FormatException)
                {
                    Console.WriteLine("You entered wrong details. Please, enter valid details\n");
                    i--;
                }
                catch (SystemException)
                {
                    Console.WriteLine("Entered invalid details");
                    i--;
                }

            }
            do
            {

                Console.WriteLine("Enter 1 to get details by name \tEnter 2 to display all records \tEnter 3 to Exit\n");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter first name to get details:");
                        string name = Console.ReadLine();
                        

                       for (i = 0; i < studentRecord.Length; i++)
                        {
                            if (studentRecord[i].firstName.Equals(name))
                            {
                                studentRecord[i].DisplayStudent();
                                break;
                            }
                        }
                        if (i == studentRecord.Length)
                        Console.WriteLine("Record not found. Please enter valid first name!!\n");
                        break;
                    case 2:
                        foreach (var item in studentRecord)
                        {
                            item.Display();
                        }
                        break;
                   
                    default:
                        IsRecord = false;
                        break;
                }

            } while (IsRecord);
            Console.WriteLine("Thank You!");
            Console.ReadLine();
        }
    }
}
