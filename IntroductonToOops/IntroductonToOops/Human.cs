using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductonToOops
{
    class Human
    {
        // Member Variable
        public string firstName="Seeta";
        public string lastName;
        public string hairColour;
        public int age;
        // Constructor
        public Human()
        {
            Console.WriteLine("This is the default Constructor");
        }
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string firstName, string lastName, string hairColour, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.hairColour=hairColour;
            this.age = age;
        }
        public void IntroduceMySelf()
        {
            Console.WriteLine("Hey! I am {0} and  {1} \n My haircolour is {2} and age is {3}", firstName,lastName,hairColour,age);
            
        }
        
    }
    
}
