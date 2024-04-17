using System;

namespace NarrativeProject.Rooms
{
    internal class Ocean : Room
    {
        internal override int id { get { return 3; } }


        internal override string CreateDescription() =>
@"You're on a very small island, lit only with tiki torches, surrounded with water
--------------------------------------------
There's sand everywhere and two large [palm] trees
--------------------------------------------
There's a leftover fishing [rod] stuck to the ground
--------------------------------------------
A [bird] is circling the island, making small sounds
--------------------------------------------
The air is clean here, it smells a little salty
--------------------------------------------
There is no [horizon], it's dark out there
--------------------------------------------
You see a [crab] family hanging by the shore
--------------------------------------------
The [door] behind you isn't connected to a wall. But you can still see the corridor inside
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "palm":
                    Console.WriteLine("The trees are tall, but you can spot some [coconut]s");
                    break;
                case "rod":
                    Console.WriteLine("The rod isn't catching anything... Wanna try [fish]ing ?");
                    break;
                case "bird":
                    Console.WriteLine("Ah.. It's out of reach..");
                    break;
                case "horizon":
                    Console.WriteLine("Now that you're looking at it, there's [something] in the distance");
                    break;
                case "crab":
                    Console.WriteLine("The crabs are playing around with a small [object]");
                    break;
                case "coconut":
                    Console.WriteLine("They look heavy. [kick] the tree ?");
                    break;
                case "fish":
                    Console.WriteLine("Aaaand... No luck. You'll need to find bait");
                    break;
                case "something":
                    Console.WriteLine("Too dark.. Maybe with a way to light the distance..");
                    break;
                case "object":
                    Console.WriteLine("It's an arrowhead! [steal] it ? or [replace] it with something from your inventory ?");
                    break;
                case "kick":
                    Console.WriteLine("One's falling! Ouch.. It hit your head. You take 5 damage. You got a coconut!");
                    break;
                case "steal":
                    Console.WriteLine("The crabs look mad! They prick at your feet. You take 10 damage");
                    break;
                case "replace":
                    Console.WriteLine("They look heavy. [kick] the tree ?"); // gotta turn this into an inventory thing instead of a switch
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
