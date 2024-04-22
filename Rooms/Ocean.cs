using System;

namespace NarrativeProject.Rooms
{
    internal class Ocean : Room
    {
        
        Random random = new Random();
        bool birdOnGround=false;    

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

                case "bird":
                    Console.WriteLine("Ah.. It's out of reach.. You'd have to [throw] stones at it, or [shoot] it down");
                    break;
                case "throw":
                    if (Game.inventory.Contains("Stone"))
                    {
                        if (random.Next(100) < 10)
                        {
                            birdOnGround = true;
                            Console.Clear();
                            Console.WriteLine("You throw a stone at it!");
                            Game.RemoveFromInventory("Stone");
                            for (int i = 0; i < 20; i++)
                            {
                                Console.WriteLine("|||");
                            }
                            Console.WriteLine("PLOP");
                            Console.WriteLine("It was holding a [bag]!");
                        }
                        else
                        {
                            Console.WriteLine("You miss! Try [throw]ing another stone!");
                            Game.RemoveFromInventory("Stone");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ah, you don't have any stones.. Hmm, maybe there's some somewhere else ?");
                    }
                    break;
                case "shoot":
                    if (Game.inventory.Contains("Bullet"))
                    {
                        birdOnGround = true;
                        Console.Clear();
                        Console.WriteLine("You throw a stone at it!");
                        Game.RemoveFromInventory("Stone");
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine("|||");
                        }
                        Console.WriteLine("PLOP");
                        Console.WriteLine("It was holding a [bag]!");
                    }
                    else
                    {
                        Console.WriteLine("*Click* *Click* AH.. no bullets");
                    }
                    break;

                case "bag":
                    if (birdOnGround)
                    {
                        Console.WriteLine("There is a folded Heatproof suit inside! You start to wear it...");
                        Game.AddToInventory("Suit");
                    }
                    else
                    {
                        Console.WriteLine("No cheating now buddy :3");
                    }
                    break;
                case "horizon":
                    Console.WriteLine("Now that you're looking at it, there's [something] in the distance");
                    break;
                case "crab":
                    Console.WriteLine("The crabs are playing around with a peculiar looking [object]");
                    break;
                case "coconut":
                    Console.WriteLine("They look heavy. [kick] the tree ?");
                    break;

                case "something":
                    Console.WriteLine("Too dark.. Maybe with a way to light the way..");
                    break;
                case "object":
                    Console.WriteLine("It's a rifle! [steal] it ?");
                    break;
                case "kick":
                    Console.WriteLine("One's falling! Ouch.. It hit your head. You take 5 damage. You got a coconut!");
                    Game.hp -= 5;
                    Game.AddToInventory("Coconut");
                    break;
                case "steal":
                    Console.WriteLine("The crabs look mad! They prick at your feet. You take 10 damage");
                    Console.WriteLine("You gain a Rifle! It seems to only have one bullet");
                    Game.AddToInventory("Rifle");
                    Game.AddToInventory("Bullet");
                    Game.hp -= 10;
                    break;
                case "door":
                    Console.WriteLine("You slowly walk back out into the corridor");
                    Game.Transition<Corridor>();
                    Game.currentRoom = new Corridor();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
