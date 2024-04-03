using System;
using System.Collections.Generic;

namespace NarrativeProject.Rooms
{
    internal class Inventory : Room
    {

        internal static List<Inventory> inventory = new List<Inventory>();

        internal override string CreateDescription() =>
@"This is your INVENTORY --- [INFO] --- [EAT] --- [COMBINE]
You have the following items:
";


    internal Inventory()
        {
            foreach (var item in inventory)
            {

            }
        }
        



    internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bath":
                    Console.WriteLine("You relax in the bath. Fog wafts up all over the bathroom");
                    
                    break;
                
                case "wolf":
                    Console.WriteLine("Buzz off, I don't feel like talkin'");
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
