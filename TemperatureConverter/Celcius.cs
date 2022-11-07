using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class Celcius
    {
        Logger logger = new Logger();

        public double CelciusToFahrenheit(double celcius)
        {
            double result = (celcius * 1.8) + 32;
            logger.Log($"{celcius} in Celcius are {result} in Fahrenheit");
            return result;
        }

        public double FahrenheitToCelcius(double fahrenheit)
        {
            double result = (fahrenheit - 32) / 1.8;
            logger.Log($"{fahrenheit} in Fahrenheit are {result} in Celcius");
            return result;
        }
    }
}
