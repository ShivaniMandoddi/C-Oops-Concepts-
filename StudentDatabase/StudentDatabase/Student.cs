using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    class Student
    {
        public string firstName, lastName, branch;
        public char section;
        public int age, marks;
        public Student(string firstName, string lastName, string branch, int age, int marks)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.branch = branch;
            this.marks = marks;
            if (this.age < 20)
                section = 'A';
            else if (this.age >= 20 && this.age <= 22)
                section = 'B';
            else
                section = 'C';
        }
        public void Display()
        {
            Console.WriteLine("Name: {0} {1}  Branch: {2}  Age: {3}  Marks: {4}\n", firstName, lastName, branch, age, marks);
        }
        public void DisplayStudent()
        {
            Console.WriteLine("Name: {0} {1}  Branch: {2}  Age: {3}  Marks: {4} Section: {5}\n", firstName, lastName, branch, age, marks,section);
        }

       
    }
}
