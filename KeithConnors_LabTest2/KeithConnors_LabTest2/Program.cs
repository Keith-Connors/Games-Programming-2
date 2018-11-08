using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithConnors_LabTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome, " + userName.ToUpper());
            Console.ReadKey();
        }
    }
}
