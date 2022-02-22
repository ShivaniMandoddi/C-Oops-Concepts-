using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnInterface
{
    /* Interface - It is like an abstract class where it can have methods and properties(with empty bodies)
     * At the begining of the interface start with letter I.
     * By default memebers of an interface are abstract and public.
     * Interface can contain properties and methods but not fields.
     * Interface cannot contain constructor
     * Why and WHen to use INterface?
     * To acheive secuirty and hide certain details and to show only important  details of an object(interface).
     * So, BAsically C# doesnot support multiple inheritance. We can achieve it through multiple interfaces. 
     * Put a Comma(,) between multiple interfaces.
     */
    /*interface IAnimal 
    {
        void Sound(); // INterface method doesn't have a body

    }
    class Dog : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Sound of a dog: Bow");
        }
    }

    
    interface IFirstInterface
    {
        void MyFirstInterface();
    }
    interface ISecondInterface
    {
        void MySecondInterface();
    }
    class TestClass: IFirstInterface,ISecondInterface
    {
        public void MyFirstInterface()
        {
            Console.WriteLine("Hello");
        }
        public void MySecondInterface()
        {
            Console.WriteLine("Bye");
        }
    }
    interface IVehicle
    {
        void ChangeGear(int gear);
        void Speed(int speed);
        void ApplyBrakes(int breaks);
    }
    class Bicycle : IVehicle
    {
        int myGear;
        int mySpeed;
        public void ChangeGear(int gear)
        {
            myGear = gear;
        }
        public void Speed(int speed)
        {
            mySpeed = mySpeed + speed;
        }
        public void ApplyBrakes(int breaks)
        {
            mySpeed = mySpeed- breaks;
        }
        public void ToPrint()
        {
            Console.WriteLine("My Gear ={0} , MyBicycle Speed= {1}",myGear,mySpeed);
        }
    }
    class Bike:IVehicle
    {
        int myGear;
        int mySpeed;
        public void ChangeGear(int gear)
        {
            myGear = gear;
        }
        public void Speed(int speed)
        {
            mySpeed = mySpeed + speed;
        }
        public void ApplyBrakes(int breaks)
        {
            mySpeed = mySpeed - breaks;
        }
        public void ToPrint()
        {
            Console.WriteLine("My Gear ={0} , My Bike Speed= {1}", myGear, mySpeed);
        }
    }*/
    /* To create an interface, where it has method for showing the notification and get date 
     I want to display sender name, message and date */
    interface IMessage
    {
        void Notification();
        string GetDate(string date);
    }
    class Sender : IMessage
    {
        string myDate;
        string myName, myMessage;
        public Sender()
        {
            myName = "Shivani";
            myMessage = "Hello Everyone";
            myDate = "February 11,2022";
        }
        public Sender(string name,string message,string date)
        {
            this.myName = name;
            this.myMessage = message;
            this.myDate = date;
        }
        public void Notification()
        {   
            Console.WriteLine("Hey you got message from {0}", myName);
            Console.WriteLine("Date : {0} \nMessage: {1}",myDate, myMessage);
        }
        public string GetDate(string date)
        {
            myDate = date;
            return(myDate);
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Dog dog = new Dog();
             dog.Sound();
            TestClass test = new TestClass();
            test.MyFirstInterface();
            test.MySecondInterface();
            Bicycle bicycle = new Bicycle();
            bicycle.ChangeGear(10);
            bicycle.Speed(20);
            bicycle.ApplyBrakes(5);
            bicycle.ToPrint();
            Bike bike = new Bike();
            bike.ChangeGear(50);
            bike.Speed(150);
            bike.ApplyBrakes(50);
            bike.ToPrint();*/
            Sender sender = new Sender("Pallavi", "Hello! How are you","Feb 12,2022");
            Sender sender1 = new Sender();
            sender1.Notification();
            sender.GetDate("February 12,2022");
            sender.Notification();
            Console.ReadLine();
        }
    }
}
