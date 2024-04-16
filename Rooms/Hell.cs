using System;

namespace NarrativeProject.Rooms
{
    internal class Hell : Room
    {
        int id = 4;
        internal static bool bomb = Corridor.isBombCollected;
        

        internal static int impNum;
        internal static int snakeBone;

        internal static bool isCodeShown = false;

        internal override string CreateDescription() =>
@"AH! The lava curtain just solidified behind you! You're trapped here
--------------------------------------------
You hear a voice from the other side: Hehe, sorry pal, nothing personal
--------------------------------------------
The room is small and hot. The walls are stone and there's more lava everywhere
--------------------------------------------
In the center of the room stands an [altar] with an [orb] on it
--------------------------------------------
There are some demonic [imp]s flying about, they seem to be mocking you
--------------------------------------------
There's a large [snake] coiling around a tall obsidian column
--------------------------------------------
A scary lava [river] is flowing down from a corner into another
--------------------------------------------
There's a huge [portal] looking structure at the end of the room
--------------------------------------------
The hell [door] is closed shut behind you..
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "altar":
                    Console.WriteLine("The altar has weird signs on it. Try to [read] them ?");
                    break;
                case "orb":
                    Console.WriteLine("The orb is ominous. Try to [seize] it ?");
                    break;
                case "imp":
                    Console.WriteLine("The imps pay you no mind. They're playing with each other. There's about "+impNum);
                    break;
                case "snake":
                    Console.WriteLine("The snake is made out of bone only. It has many bones... You count about "+snakeBone);
                    break;
                case "river":
                    Console.WriteLine("A source of molten lava");
                    break;
                case "portal":
                    Console.WriteLine("Large and uncanny. The portal awaits an item for its circular [slot]");
                    break;
                case "door":
                    if (!bomb)
                    {
                        if (!bomb)
                        {
                            Console.WriteLine("Ah.. can't go through solid obsidian. You'd need to [blow] it up!");
                        }
                        else
                        {
                            Console.WriteLine("BOOM! Woah! You completely destroyed the wall! You can go through the [door] now!");

                        }
                    }
                    else
                    {
                        Console.WriteLine("You go through the wide open door");
                        Game.Transition<Corridor>();
                    }
                    break;
                case "read":
                    if (!bomb)
                    {
                        Console.WriteLine("Gibberish.. If only you had");
                    }
                    else
                    {
                        Console.WriteLine("BOOM! Woah! You completely destroyed the wall! You can go through the [door] now!");

                    }
                    break;
                case "seize":
                    Console.WriteLine("The altar has weird signs on it. Try to [read] them ?");
                    break;
                case "slot":
                    Console.WriteLine("The altar has weird signs on it. Try to [read] them ?");
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
