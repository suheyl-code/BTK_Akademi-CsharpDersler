﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var machineName = Environment.MachineName;
            Console.WriteLine(machineName + " " + machineName.GetType());

        }
    }
}
