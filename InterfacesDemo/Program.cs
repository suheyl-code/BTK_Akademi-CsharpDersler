using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] worker = new IWorker[2]
            {
                new Worker(),
                new Robot()
            };

            IEater[] eater = new IEater[1]
            {
                new Worker()
            };

            ISalaryGetter[] salaryGetter = new ISalaryGetter[1]
            {
                new Worker()
            };

            foreach (var item in worker)
            {
                item.Work();
            }
            foreach (var item in eater)
            {
                item.Eat();
            }
            foreach (var item in salaryGetter)
            {
                item.GetYourSalary();
            }


        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEater
    {
        void Eat();
    }

    interface ISalaryGetter
    {
        void GetYourSalary();
    }

    class Worker : IWorker, IEater, ISalaryGetter
    {
        public string Name { get; set; } = "<Worker>";

        public void Eat()
        {
            Console.WriteLine($"{Name} able to Eat");
        }

        public void GetYourSalary()
        {
            Console.WriteLine($"{Name} able to get Salary");
        }

        public void Work()
        {
            Console.WriteLine($"{Name} Working");
        }
    }

    class Robot : IWorker
    {
        public string Name { get; set; } = "<Robot>";

        public void Work()
        {
            Console.WriteLine($"{Name} Working");
        }
    }
}
