using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToStatic
{
    class Program
    {
        /*Introduction: Static class is basically same as non static classes but with a difference where you cannot instanstiate or create new object of it.
         * Because there is no instance variable , you acess the members for static class by using the class name itself.
         * Ex: Static utility class has a static method is a method
         * UtilityClass.MethodA()
         */
        // This is an example for static class that contains two methods to convert temperature from celsius to fahrenheit and fahrenheit to celsius

        static void Main(string[] args)
        {
            Console.WriteLine("Please select the converter direction\n1 for Celsius to Fahrenheit \n2 for fahrenheit to Celsius");
            string tempValue = Console.ReadLine();
            float F, C;
            switch (tempValue)
            {
                case "1": Console.WriteLine("Please Enter the Celsius temperature");
                    F = TemperatureConvert.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit is "+F);
                    break;
                case "2": Console.WriteLine("Please Enter the Fahrenheit temperature");
                    C = TemperatureConvert.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius is "+C);
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
            Console.ReadLine();

        }
    }
   
}
