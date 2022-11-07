using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter.Logger
{
    public class LoggerStub : ILogger
    {
        public bool Log(string message)
        {
            return true;
        }
    }
}
