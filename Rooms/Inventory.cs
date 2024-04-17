using System;

namespace NarrativeProject.Rooms
{
    internal class Inventory : Room
    {
        internal override int id { get { return 6; } }

        internal override string CreateDescription() =>
@"This is your INVENTORY
You have the following items:
";

        internal override void ReceiveChoice(string choice)
        {
            Console.WriteLine("You are in the inventory room.");
            Console.WriteLine("You can't do anything here except view your items.");
        }
    }
}
