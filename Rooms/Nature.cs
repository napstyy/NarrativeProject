using System;

namespace NarrativeProject.Rooms
{
    internal class Nature : Room
    {
        internal static bool isKeyCollected;

        internal override string CreateDescription() =>
@"You're in the nature room. It's a small enclosure with plants and animals
--------------------------------------------
There are large trees with [branch]es reaching all the way to the darkness above,
their [vine]s reach all the way to the ground
--------------------------------------------
There are bushes with a new type of [berry], they look delicious
--------------------------------------------
There's a few small critters, [rabbit]s and [frog]s
--------------------------------------------
There's a big sleeping [bear]. It seems dangerous. There's something behind it
--------------------------------------------
You see a fake [sun]
--------------------------------------------
There's a small artificial [river] with [fish] in it
--------------------------------------------
Plenty of rocks and [stone]s here
--------------------------------------------
The nature [door] is wide open behind you
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "berry":
                    Console.WriteLine("You got a berry!");
                    break;
                case "rabbit":
                    Console.WriteLine("The rabbit skitters away from you!");
                    break;
                case "frog":
                    Console.WriteLine("The frog hops away from you!");
                    break;
                case "bear":
                    Console.WriteLine("The bear is asleep, you don't want to [wake] it up");
                    break;
                case "sun":
                    Console.WriteLine("The fake sun is just as hot as a real sun");
                    break;
                case "river":
                    Console.WriteLine("A source of clean water");
                    break;
                case "fish":
                    Console.WriteLine("The fish are too hard to catch");
                    break;
                case "vine":
                    Console.WriteLine("You cut through the vines with the handsaw! You get a spool of vine");
                    break;
                case "stone":
                    Console.WriteLine("You get a stone!");
                    break;
                case "wake":
                    Console.WriteLine("You wake up the bear! It's angry and swipes at your face. You take 10 damage");
                    break;
                case "branch":
                    Console.WriteLine("You cut through a branch! You get a stick!");
                    break;
                case "door":
                    Console.WriteLine("You slowly walk back out into the corridor");
                    Game.Transition<Corridor>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
