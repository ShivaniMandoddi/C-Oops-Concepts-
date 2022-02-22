using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToStatic
{
    public static class TemperatureConvert
    {
        public static float CelsiusToFahrenheit(string value)
        {
            float celsius = float.Parse(value);
            float fahrenheit = (celsius * 9 / 5) + 32;
            return (fahrenheit);
        }
        public static float FahrenheitToCelsius(string value)
        {
            float fahrenheit = float.Parse(value);
            float celsius = (fahrenheit - 32) * 5 / 9;
            return (celsius);
        }
    }
}
