using System;

namespace NarrativeProject.Rooms
{
    internal class Nature : Room
    {
        internal static bool isKeyCollected;

        internal override string CreateDescription() =>
@"You're in the nature room. It's a small enclosure with plants and animals
--------------------------------------------
There are large trees reaching all the way to the darkness above
--------------------------------------------
There are bushes with ripe berries, they look delicious
--------------------------------------------
There's a few small critters, rabbits and frogs
--------------------------------------------
There's a big sleeping bear. It seems dangerous. There's something behind it
--------------------------------------------
There is a [hell] door, covered in molten rock and lava
--------------------------------------------
The corridor boasts a long [carpet]
--------------------------------------------
There's a [mirror] on the other side of the wall
in front of the wolf man
--------------------------------------------
The corridor doesn't seem to end, but there aren't any lights
beyond where you are. It's pure void and darkness on both sides
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
                    isKeyCollected = true;
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
