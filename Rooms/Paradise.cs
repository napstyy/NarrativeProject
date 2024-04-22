using System;

namespace NarrativeProject.Rooms
{
    internal class Paradise : Room
    {
        

        internal static bool isCodeShown = false;

        internal override string CreateDescription() =>
@"You're on a cloud . . .
--------------------------------------------
There's light everywhere . . .
--------------------------------------------
That's an [angel] in front of you . . .
--------------------------------------------
You feel serene . . .
--------------------------------------------
Is it time to let go ? . . .
--------------------------------------------
Or maybe . . .
--------------------------------------------
You want to get your revenge . . .
--------------------------------------------
Should you [rest] ? Or should you go back to the [corridor] . . .
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "angel":
                    Console.WriteLine("Be not afraid");

                    break;
                case "rest":
                    Console.WriteLine("You let go . . . It feels good . . . Goodnight . . .");
                    Game.Finish();
                    break;
                case "corridor":
                    Console.WriteLine("It's you and your backpack against the wolf . . .");
                    Game.Transition<Purgatory>();
                    Game.currentRoom = new Purgatory();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
