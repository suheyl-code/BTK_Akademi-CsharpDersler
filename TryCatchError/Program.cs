using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchError
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SimpleTryCatch();

            // Making own Exception class
            try
            {
                RecordFinding();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }


            // Same as above but with Action Deligate, more advanced technique
            RecordNotFoundException.HandleException(() =>
            {
                RecordFinding();
            });
        }
        

        private static void RecordFinding()
        {
            // Using Own Exception Class
            string[] myNames = new string[3] { "Alex", "Amy", "Josef" };
            if (!myNames.Contains("Bob"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void SimpleTryCatch()
        {
            try
            {
                string[] myNames = new string[3] { "Alex", "Amy", "Josef" };
                myNames[3] = "Bob";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
    }
}
