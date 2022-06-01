using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Server Add Function!");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Server Delete Function!");
        }

        public void Update()
        {
            Console.WriteLine("SQL Server Update Function!");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Add Function!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Delete Function!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Update Function!");
        }
    }

    class DatabaseManager
    {
        public void Function(ICustomerDal customerDal)
        {
            customerDal.Add();
            customerDal.Update();
            customerDal.Delete();
        }
    }
}
