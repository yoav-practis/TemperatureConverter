using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class Celcius
    {
        ILogger logger;

        public Celcius(ILogger logger)
        {
            this.logger = logger;
        }

        public float CelciusToFahrenheit(float celcius)
        {
            float result = (celcius * 1.8f) + 32;
            logger.Log($"{celcius} in Celcius are {result} in Fahrenheit");
            return result;
        }

        public float FahrenheitToCelcius(float fahrenheit)
        {
            float result = (fahrenheit - 32) / 1.8f;
            logger.Log($"{fahrenheit} in Fahrenheit are {result} in Celcius");
            return result;
        }
    }
}
