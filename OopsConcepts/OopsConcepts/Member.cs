using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OopsConcepts
{
    
    class Member
    {
        //private field - members
        private string memberTitle;
        private string memberName;

        //public field - members
        public int memberAge;
        private int salary;

        // member property exposes memberTitle safely.
        //member properties will start with capital letters.
        public string MemberTitle { get { return MemberTitle; } set { MemberTitle = value; } }
        public string MemberName { get {return MemberName;} set {MemberName=value;} }
        // public member method - can be called from other classes
        public void Introducing(bool IsSharable)
        {
            //Console.WriteLine("Hello!");
            if(IsSharable)
            {
                SharingInformation();
            }
            else
            {
                Console.WriteLine("Hello! My name is {0},My title is {1} and I am {2}years old",memberName,memberTitle,memberAge);
            }
            
        }
        private void SharingInformation()
        {
            Console.WriteLine("My Salary is {0} ",salary);
        }

        // member Constructor
        public Member()
        {
            Console.WriteLine("Object is created");
        }
        /* Destructors
         * Destructors in c# are methods inside the class use to destroy the instance of the class
         * Destructor is a unique to it's class there cannot be more than one destructor 
         * It has no return type
         * It has exactly same name as the class name
         * It is prefixed to its name by (tilde) '~' symbol
         * It does not accept any parameters and modifiers.
         * It cannot be overloaded or inherited.
         * Its called when the program exit.
         */
        ~Member()
        {
            Console.WriteLine("Deconstruction of Members object");
            Debug.WriteLine("Hey! Deconstrution of Members object");
            // Clean Up statements
        }

    }
}
