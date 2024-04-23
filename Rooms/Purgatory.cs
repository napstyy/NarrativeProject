using System;
using System.Collections.Generic;

namespace NarrativeProject.Rooms
{
    internal class Purgatory : Room
    {

        public override void gameDone()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine("YOU KILLED HIM");
            }

            Console.ReadLine();
        }






        Random random = new Random();


        internal static int wolfhp = 50;


        internal static int timesEnteredNature = 0;


        internal override string CreateDescription() =>
$@" WOLF HEALTH: {wolfhp}
--------------------------------------------
*Hey pal*  
--------------------------------------------
*I've been watching you*
--------------------------------------------
*You're too smart to let go wander into the world*
--------------------------------------------
*I had to do it y'know*
--------------------------------------------
*Anyways, take this!*
--------------------------------------------
The wolf throws a lava bucket at your face. But you're immune!
--------------------------------------------
[throw] stones at him ?
--------------------------------------------
[poke] him with sticks ?
--------------------------------------------
[shoot] him ?
--------------------------------------------
launch [coconut]s ... at him .. ??
";

        internal override void ReceiveChoice(string choice)
        {
            while (wolfhp > 0) 
            {
                switch (choice)
                {
                    case "throw":
                        if (Game.inventory.Contains("Stone"))
                        {
                            if (random.Next(100) < 75)
                            {
                                Console.WriteLine("You hit him in the face!");
                                Game.RemoveFromInventory("Stone");
                                wolfhp -= 5;

                            }
                            else
                            {
                                Console.WriteLine("You miss! The wolf shoots a dart at you!");
                                Game.RemoveFromInventory("Stone");
                                Game.hp -= 3;

                            }

                        }
                        else
                        {
                            Console.WriteLine("No stones in your pack! Do something else!");

                        }

                        break;
                    case "poke":
                        if (Game.inventory.Contains("Stick"))
                        {
                            if (random.Next(100) < 75)
                            {
                                Console.WriteLine("You stab him! Your stick breaks!");
                                Game.RemoveFromInventory("Stick");
                                wolfhp -= 10;

                            }
                            else
                            {
                                Console.WriteLine("He dodges masterfully! Your stick breaks! The wolf man claws at you!");
                                Game.RemoveFromInventory("Stick");
                                Game.hp -= 5;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Ugh! You left all the sticks at the Nature door!");

                        }
                        break;
                    case "coconut":
                        if (Game.inventory.Contains("Coconut"))
                        {
                            Console.WriteLine("You coconut the wolf!");
                            wolfhp -= 20;

                        }
                        else
                        {
                            Console.WriteLine("No more coconuts!");

                        }
                        break;
                    case "shoot":
                        if (Game.inventory.Contains("Bullet"))
                        {

                            Console.WriteLine("BANG! . . .");
                            Console.WriteLine("RIGHT IN THE CHEST");
                            wolfhp -= 50;
                        }
                        else
                        {
                            Console.WriteLine("No ammo! As you fumble around, the wolf slashes you with a blade!");
                            Game.hp -= 10;

                        }
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }

                Console.WriteLine("--");
                Console.WriteLine("Current Health: " + Game.hp);
                Console.WriteLine("--");
                Console.WriteLine("Open your inventory with [i]");
                Console.WriteLine("--");
                Console.WriteLine(CreateDescription());
                
                choice = Console.ReadLine().Trim().ToLower();
                Console.Clear();
            }
            Console.Clear();
            gameDone();
            Game.Finish();

            
        }
    }
}
