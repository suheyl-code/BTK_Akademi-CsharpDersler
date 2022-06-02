using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // One thing you cannot do with Interfaces is this. Check the example here.
    // virtual - override
    
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added to Database.");
        }

        public virtual void Update()
        {
            Console.WriteLine("Database Updated.");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            base.Add();
            Console.WriteLine("SQL Server <Add> Functionality applied.");
        }

        public override void Update()
        {
            base.Update();
            Console.WriteLine("SQL Server <Update> Functionality applied.");
        }
    }
}
