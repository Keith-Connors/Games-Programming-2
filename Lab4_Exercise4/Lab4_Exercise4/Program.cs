using System;
namespace Lab4_Exercise4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = 0,
                x = 1,
                y,
                number;
            
            Console.WriteLine("Enter a number for the sequence");
            number = int.Parse(Console.ReadLine());
            
            Console.WriteLine(n + " "+ x +" ");

            for (int j = 2; j < number; j++)
            {
                y = n + x;
                Console.WriteLine(y + " ");
                n = x;
                x = y;
            }

            Console.ReadKey();
        }
    }
}