using System;

namespace NarrativeProject.Rooms
{
    internal class Paradise : Room
    {
        int id = 5;

        internal static bool isCodeShown = false;

        internal override string CreateDescription() =>
@"In your bathroom, the [bath] is filled with hot water.
The [mirror] in front of you reflects your depressed face.
You can return to your [bedroom].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bath":
                    Console.WriteLine("You relax in the bath. Fog wafts up all over the bathroom");
                    isCodeShown = true;
                    break;
                case "mirror":
                    if (!isCodeShown)
                    {
                        Console.WriteLine("There's unclear numbers written on the foggy mirror.");
                    }
                    else
                    {
                        Console.WriteLine("The code is clear now. It is 6969");
                        
                    }
                    break;
                case "bedroom":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Corridor>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
