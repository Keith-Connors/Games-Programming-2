using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithConnors_LabTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to play the game? ");
            string option = Console.ReadLine();

            switch(option)
            {
                case ("yes"):
                case ("y"):
                    if (option == "yes" || option == "yes")
                    {
                        Console.WriteLine("You have chosen to play.");
                        Console.ReadKey();
                    }
                    break;

                case ("no"):
                case ("n"):
                    Console.WriteLine("You have chosen not to play");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("You have selected an invalid option, Yes or No only.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
