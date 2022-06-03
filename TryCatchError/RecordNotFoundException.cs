using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Making own exception class for handling specific problems.
namespace TryCatchError
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message) : base (message)
        {

        }

        public static void HandleException(Action value)
        {
            try
            {
                value.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
