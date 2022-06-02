using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cm = new CustomerManager();
            cm.Logger = new DatabaseLogger();   // Change this and good to go. SOLID principles applied.
            //cm.Logger = new SMSLogger();
            cm.Add();
            
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
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
