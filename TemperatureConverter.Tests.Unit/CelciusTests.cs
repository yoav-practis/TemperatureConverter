using NUnit.Framework;
using System;
using TemperatureConverter.Logger;

namespace TemperatureConverter.Tests.Unit
{
    public class CelciusTests
    {
        private Celcius celcius;
        
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            ILogger logger = new LoggerStub();
            celcius = new Celcius(logger);
        }

        [Test]
        public void CelciusToFahrenheit_PositiveValue_CorrectValue()
        {
            // Arrange
            float expected = 98.6f;

            // Act
            float actual = celcius.CelciusToFahrenheit(37);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FahrenheitToCelcius_PositiveValue_CorrectValue()
        {
            // Arrange
            float expected = 37;

            // Act
            float actual = celcius.FahrenheitToCelcius(98.6f);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
