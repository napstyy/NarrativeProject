using System;

namespace NarrativeProject.Rooms
{
    internal class Nature : Room
    {


        private Random random = new Random();


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
                    Game.AddToInventory("Berry");
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
                    
                    if (Game.inventory.Contains("Stick"))
                    {
                        if (random.Next(100) < 50)
                        {
                            Console.WriteLine("You catch a fish!");
                            Game.AddToInventory("Fish");
                        }
                        else
                        {
                            Console.WriteLine("You waste a stick trying to hunt for fish... try to [fish] again ?");
                            Game.RemoveFromInventory("Stick");
                        }  
                        
                    }
                    else
                    {
                        Console.WriteLine("The fish are too hard to catch without a fishing rod or a stick");

                    }
                    break;
                case "vine":
                    Console.WriteLine("You cut through the vines with the handsaw! You get rope!");
                    Game.AddToInventory("Rope");
                    break;
                case "stone":
                    Console.WriteLine("You get a stone!");
                    Game.AddToInventory("Stone");
                    break;
                case "wake":

                    int timesFed = 0;
                    int timesNeeded = random.Next(1,6);

                    while (Game.inventory.Contains("Fish"))
                    {
                        Game.RemoveFromInventory("Fish");
                        timesFed ++;
                    }

                    if (timesFed==0)
                    {
                        Console.WriteLine("The bear wants fish!! He swipes at you for 10 damage!");
                        Game.hp = Game.hp-10;
                    }
                    else if (timesFed < timesNeeded)
                    {
                        Console.WriteLine("The bear wants more fish!! He swipes at you for 10 damage!");
                        Game.hp = Game.hp - 10;
                    }
                    else
                    {
                        Console.WriteLine("You fed the bear " + timesFed + " Fish!! He only wanted " + timesNeeded + " Fish!");
                        Game.AddToInventory("Hammer");
                    }
                    

                    
                    break;
                case "branch":
                    Console.WriteLine("You cut through a branch with the handsaw! You get a stick!");
                    Game.AddToInventory("Stick");
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
