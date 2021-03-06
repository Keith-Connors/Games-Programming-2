﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithConnors_LabTest4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is the enemy visible to you?");
            string option = Console.ReadLine();
            switch (option)
            {
                case ("n"):
                case ("no"):
                    if (option == "n" || option == "no")
                    {
                        Console.WriteLine("Does the enemy make a sound?");
                        option = Console.ReadLine();
                        switch (option)
                        {
                            case ("y"):
                            case ("yes"):
                                Console.WriteLine("You can hear the enemy, you choose to");
                                Console.WriteLine("Creep");
                                Console.WriteLine("Run");

                                option = Console.ReadLine();
                                switch (option)
                                {
                                    case ("Creep"):
                                    case ("creep"):

                                        if(option == "creep" || option == "Creep")
                                        {
                                            Console.WriteLine("You creep up behind the enemy taking them by surprise and kill them");
                                            Console.ReadKey();
                                        }
                                        break;

                                    case ("run"):
                                    case ("Run"):
                                        if (option == "run" || option == "Run")
                                        {
                                            Console.WriteLine("You have chosen to run away, you have failed.");
                                            Console.ReadKey();
                                        }
                                        break;

                                    default:
                                        Console.WriteLine("Invalid option selected");
                                        Console.ReadKey();
                                        break;
                                }
                                break;

                            case ("n"):
                            case ("no"):
                                Console.WriteLine("You didn't hear or see the enemy, letting them attack you from behind, You have died.");
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine("Invalid option selected");
                                break;
                        }
                    }
                    break;

                case ("y"):
                case ("yes"):
                    if (option == "y" || option == "yes")
                    {
                        Console.WriteLine("Is the enemy less than 10m away from you?");
                        option = Console.ReadLine();
                        switch (option)
                        {
                            case ("y"):
                            case ("yes"):
                                if (option == "yes" || option == "y")
                                {
                                    Console.WriteLine("With the enemy so close, you choose to");
                                    Console.WriteLine("Shoot");
                                    Console.WriteLine("Run");
                                    option = Console.ReadLine();

                                    switch (option)
                                    {
                                        case ("shoot"):
                                            if(option == "shoot")
                                            {
                                                Console.WriteLine("You shoot and kill the enemy.");
                                                Console.ReadKey();
                                            }
                                            break;

                                        case ("run"):
                                            if(option == "run")
                                            {
                                                Console.WriteLine("You have chosen to run away and have failed.");
                                                Console.ReadKey();
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("Invalid option selected.");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                break;

                            case ("n"):
                            case ("no"):
                                if(option == "no")
                                {
                                    Console.WriteLine("Is the enemy flanking your position?");
                                    option = Console.ReadLine();
                                    switch (option)
                                    {
                                        case ("no"):
                                        case ("n"):
                                            if (option == "no" || option == "n")
                                            {
                                                Console.WriteLine("The enemy is not on the move, what do you choose to do?");
                                                Console.WriteLine("Attack");
                                                Console.WriteLine("Run");
                                                option = Console.ReadLine();
                                                switch (option)
                                                {
                                                    case ("run"):
                                                        if(option == "run")
                                                        {
                                                            Console.WriteLine("You have chosen to run away, you have failed.");
                                                            Console.ReadKey();
                                                        }
                                                        break;

                                                    case ("attack"):
                                                        if(option == "attack")
                                                        {
                                                            Console.WriteLine("You attack the enemy, as close as it was, you come out the winner.");

                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    default:
                                                        Console.WriteLine("Invalid option selected.");
                                                        Console.ReadKey();
                                                        break;
                                                }
                                            }
                                            break;

                                        case ("yes"):
                                        case ("y"):
                                            if (option == "y" || option == "yes")
                                            {
                                                Console.WriteLine("The enemy is flanking your position, you choose to");
                                                Console.WriteLine("Stay");
                                                Console.WriteLine("Move");
                                                option = Console.ReadLine();
                                                switch (option)
                                                {
                                                    case ("stay"):
                                                        if(option == "stay")
                                                        {
                                                            Console.WriteLine("You have chosen to stay and have been flanked by the enemy. They kill you instantly");
                                                            Console.ReadKey();
                                                        }
                                                        break;

                                                    case ("move"):
                                                        if(option == "move")
                                                        {
                                                            Console.WriteLine("You move to another position, throwing the enemy off your trail");
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    default:
                                                        Console.WriteLine("Invalid option selected");
                                                        Console.ReadKey();
                                                        break;
                                                }
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("Invalid option selected.");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                break;

                            default:
                                Console.WriteLine("Invalid option selected.");
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
    }
}
