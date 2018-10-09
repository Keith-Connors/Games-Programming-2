using System;
using System.Security.Cryptography.X509Certificates;

namespace Lab4_Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a valid number to get the times tables");
            String myNumber = Console.ReadLine();
                
                while(String.IsNullOrEmpty(myNumber) || !int.TryParse(myNumber, out n))
            {
                Console.WriteLine("Enter a valid number. \n try again.");
                myNumber = Console.ReadLine();
            }
            Console.WriteLine("Output: for x "+ n);

            for (int i = 0; i <= 20 ; i++)
            {
                Console.WriteLine(i * n);
            }
        }
    }
}