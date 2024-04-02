using System;

namespace NarrativeProject.Rooms
{
    internal class AtticRoom : Room
    {
        

        internal override string CreateDescription() =>
@"In the attic, it's dark and cold.
A chest is locked with the code [????].
You can return to your [bedroom].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bedroom":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Corridor>();
                    break;
                case "6969":
                    Console.WriteLine("The chest opens and you get a key.");
                    
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
