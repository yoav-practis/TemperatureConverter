using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class LoggerImpl : ILogger
    {
        public bool Log(string message)
        {
            string fullMessage = EnhanceMessage(message);
            Console.WriteLine(fullMessage);
            return true;
        }

        private string EnhanceMessage(string message)
        {
            Random random = new Random();
            int chanceOfFailing = random.Next(0, 2);

            if (chanceOfFailing > 0)
            {
                throw new Exception("Oh no! Something went wrong!");
            }
            else
            {
                return "[INFO] " + message;
            }
        }
    }
}