using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnPolymorphism
{
    class Program
    {
        /* Polymorphism means many forms and it occurs when we have many classes that are related to each other by inheritance 
         * Like inheritance lets us use fields and methods from another class
         * Polymorphism uses those methods to perform different tasks
         * This allows us to perform a single action in different ways.
         * Ex: Animal is a base class that has method sound. Pig, Dog, Cat are derived classes will implement the method Animal sound in its own way.
         * Why to Use and When to Use
         * Its useful for code reusability.
         * Note: C# provides an option to override the base class method by adding the keyword virtual to the method inside the base class
         * By using the keyword override for each derived class methods.
         */
        
        static void Main(string[] args)
        {
            /*   Animal animal = new Animal();
            Dog dog = new Dog();
            Pig pig = new Pig();
            Cat cat = new Cat();
            animal.Sound();
            dog.Sound();
            pig.Sound();
            cat.Sound();
            MyClass myClass = new MyClass();
            MySecondClass mySecondClass = new MySecondClass();
            MyThirdClass myThirdClass = new MyThirdClass();
            myClass.MyBaseMethod();
            mySecondClass.MyBaseMethod();
            myThirdClass.MyBaseMethod();*/
            Car car = new Car("120", "black");
            car.ShowMeDetails();
            car.Repair();
            Tata tata = new Tata("130", "blue","Model2", "Tata");
            tata.ShowMeDetails();
            tata.Repair();
            Suzuki suzuki = new Suzuki("150", "black", "Model4", "Suzuki");
            suzuki.Repair();
            suzuki.ShowMeDetails();
            Console.ReadLine();
        }
    }
    /* Create a base class with two properties power and colour.
     * Create a constructor for setting those two properties
     * Create a method called ShowMeDetails which shows the power and colour of the car
     * Create a another method called Repair method where it should display car was repaired
     * Create two deriving classes Tata,Suzuki which have their own constructor and have an a additional property car model also private
     * property brand.
     * Brand should be different in each of the two classes.
     * Create two methods show details and repair in them as well adjust those methods accordingly.
     */
    /*Assessment: Implement a basic Banking Application by implementing account class along with two derived classes savingsaccount and currentaccount.
     * Deposit method and Withdrawl method. Print Balance amount in the account.
     */
    class Car
    {
        public string power, colour;
        public string Power { get {return(power); } set {power=value; } }
        public string Colour { get { return (colour); } set { colour = value; } }
        public Car(string power,string colour)
        {
            this.power = power;
            this.colour = colour;
        }
        public virtual void ShowMeDetails()
        {
            Console.WriteLine("Power : {0} , Colour : {1}",power,colour);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
    class Tata : Car
    {
        string carModel;
        private string brand;
        public string CarModel { get { return (carModel); } set { carModel = value; } }
        public string Brand { get {return(brand); } set { brand = value; } }
        public Tata(string power, string colour, string carModel, string brand): base(power, colour)
        {
            this.power = power;
            this.colour = colour;
            this.carModel = carModel;
            this.brand = brand;
        }
        public override void ShowMeDetails()
        {
            Console.WriteLine("Power :{0} , Colour: {1}, Car Model: {2}, Brand: {3}",power,colour,carModel,brand);
        }
        public override void Repair()
        {
            Console.WriteLine("{0} was repaired",brand);
        }

    }
    class Suzuki : Car
    {
        string carModel;
        private string brand;
        public string CarModel { get { return (carModel); } set { carModel = value; } }
        public string Brand { get { return (brand); } set { brand = value; } }
        public Suzuki(string power, string colour, string carModel, string brand): base(power,colour)
        {
            this.power = power;
            this.colour = colour;
            this.carModel = carModel;
            this.brand = brand;
        }
        public override void ShowMeDetails()
        {
            Console.WriteLine("Power :{0} , Colour: {1}, Car Model: {2}, Brand: {3}", power, colour, carModel, brand);
        }
        public override void Repair()
        {
            Console.WriteLine("{0} was repaired",brand);
        }

    }


    /*
    class MyClass // This is a base class
    {
        public virtual void MyBaseMethod()
        {
            Console.WriteLine("This is a base method");
        }
    }
    class MySecondClass : MyClass
    {
        public override void MyBaseMethod()
        {
            Console.WriteLine("This is from Second Class Base Method");
        }
    }
    class MyThirdClass : MyClass
    {
        public override void MyBaseMethod()
        {
            Console.WriteLine("This is from Third Class Base Method");
        }
    }


    class Animal
    {
        public void Sound()
        {
            Console.WriteLine("Animals make Sounds");
        }
    }
    class Pig:Animal
    {
        public void Sound()
        {
            Console.WriteLine("This is a Pig Sound");
        }
    }
    class Dog : Animal
    {
        public void Sound()
        {
            Console.WriteLine("This is a Dog Sound");
        }
    }
    class Cat : Animal
    {
        public void Sound()
        {
            Console.WriteLine("This is a Cat Sound");
        }
    }*/
}
