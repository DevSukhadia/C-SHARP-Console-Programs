using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneMethod
{
    class OneMethod
    {
        static void Main(string[] args)
        {
            string myChoice;

            OneMethod om = new OneMethod();
            
            do
            {
                
                
                //Retrieve user's choice
                myChoice = om.getChoice();

                switch (myChoice)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("You wish to add new address");
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("You wish to delete an address");
                        break;
                    case "M":
                    case "m":
                        Console.WriteLine("You wish to modify an address");
                        break;
                    case "V":
                    case "v":
                        Console.WriteLine("You wish to view an address");
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Bye!");
                        break;
                    default :
                        Console.WriteLine("{0} is not a valid Choice", myChoice);
                        break;
                }
                Console.WriteLine("Press enter key to Continue");
                Console.ReadLine();

            } while(myChoice != "Q" && myChoice != "q");
        }

        string getChoice()
        {
            string myChoice;

            Console.WriteLine("My Address Book\n");

            Console.WriteLine("A- Add nhew address");
            Console.WriteLine("D- Delete address");
            Console.WriteLine("M- Modufy address");
            Console.WriteLine("V- View address");
            Console.WriteLine("Q- Quit");

            Console.WriteLine("Choice (A, D, M, V or Q): ");
            myChoice = Console.ReadLine();
            Console.WriteLine();

            return myChoice;
        }
    }
}
