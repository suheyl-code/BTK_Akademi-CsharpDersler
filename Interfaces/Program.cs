using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //DatabaseManager dbManager = new DatabaseManager();
            //dbManager.Function(new SqlServerCustomerDal());
            //dbManager.Function(new OracleCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void InterfacesIntro()
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demir",
                Address = "Ankara / Çankaya"
            };

            Student student1 = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demir",
                Department = "Computer Scşences"
            };

            PersonManager manager = new PersonManager();
            manager.Add(customer1);
            manager.Add(student1);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine($"{person.Id}: {person.FirstName} {person.LastName}");
        }
    }
}
