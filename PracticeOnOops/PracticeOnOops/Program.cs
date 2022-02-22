using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnOops
{
    class Program
    {
        /* Create student database, name,rollno, personal information, branch
         * Branch wise displaying student information
         */
        static void Main(string[] args)
        {
            Student student = new Student(1,"Shivani",20,90);
            Cse cse = new Cse(2, "Srija", 22, 94);
            Cse cse1 = new Cse(3, "Malavika", 20, 91);
            Ece ece = new Ece(1, "Manisha", 23, 95);
            Ece ece1 = new Ece(2, "Pranaya", 19, 90);
            Eee eee = new Eee(1, "Jyothi", 18, 85);
            Eee eee1 = new Eee(2, "Laya", 19, 68);
            student.Display();
            Console.WriteLine("Students from Cse");
            cse.Display();
            cse1.Display();
            Console.WriteLine("Students from Ece");
            ece.Display();
            ece1.Display();
            Console.WriteLine("Stuents from Eee");
            eee.Display();
            eee1.Display();
            Console.ReadLine();

        }
    }

    class Student
    {
        public string name;
        public int grade, rollNo,age;
        public string Name { get { return (name); } set { name = value; } }
        public Student(int rollNo,string name,int age,int grade)
        {
            this.name = name;
            this.rollNo = rollNo;
            this.grade = grade;
            this.age = age;
        }
        public virtual void Display()
        {
            Console.WriteLine("RollNo : {0}, Name: {1}, Age: {2},Grade: {3}",rollNo,name,age,grade);
        }

    }
    class Cse : Student
    {
        string branch = "CSE";
        public Cse(int rollNo, string name, int age, int grade): base(rollNo,name,age,grade)
        {
            this.name = name;
            this.rollNo = rollNo;
            this.grade = grade;
            this.age = age;
          
        }
        public override void Display()
        {
            Console.WriteLine("RollNo : {0}, Name: {1}, Age: {2},Grade: {3},Branch : {4}", rollNo, name, age, grade,branch);
        }

    }
    class Ece : Student
    {
        string branch = "ECE";
        public Ece(int rollNo, string name, int age, int grade) : base(rollNo, name, age, grade)
        {
            this.name = name;
            this.rollNo = rollNo;
            this.grade = grade;
            this.age = age;

        }
        public override void Display()
        {
            Console.WriteLine("RollNo : {0}, Name: {1}, Age: {2},Grade: {3},Branch : {4}", rollNo, name, age, grade, branch);
        }

    }
    class Eee : Student
    {
        string branch = "EEE";
        public Eee(int rollNo, string name, int age, int grade) : base(rollNo, name, age, grade)
        {
            this.name = name;
            this.rollNo = rollNo;
            this.grade = grade;
            this.age = age;

        }
        public override void Display()
        {
            Console.WriteLine("RollNo : {0}, Name: {1}, Age: {2},Grade: {3},Branch : {4}", rollNo, name, age, grade, branch);
        }

    }

}
