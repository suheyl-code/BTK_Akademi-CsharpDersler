using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo3
{
    internal class Program
    {
        // Enhanced version of InterfacesDemo2 Project.
        static void Main(string[] args)
        {
            CustomerManager cm = new CustomerManager(new SMSLogger());
            cm.Add();
        }
    }

    class CustomerManager
    {
        private ILogger _logger { get; set; }

        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
        }
    }

    interface ILogger
    {
        void Log();
    }

    class SMSLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS Service.");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database Service.");
        }
    }
}
