using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TransactionManager";

            Console.WriteLine("Trasanction Manager starter working..");

            TransactionResourceHost host = new TransactionResourceHost();
            host.Open();

            Console.WriteLine("Press any key to close service..");
            Console.ReadKey();
        }
    }
}
