using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Exercise1
{
    class Program
    { 
        public static void Main(string[] args)  
        {
            int valueX = 10;
            int valueY = 20;
            int myResult = multiplyFunction(valueX, valueY);
                
            Console.WriteLine("My function result is: "+ myResult);
            Console.ReadKey();
        }

        static int multiplyFunction(int a, int b)
        {
            var mult = a * b;

            return mult;
        }
    }
}
