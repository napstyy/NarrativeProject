using System;

namespace NarrativeProject.Rooms
{
    internal class Hell : Room
    {
        


        internal static bool bomb = Corridor.isBombCollected;

        internal static bool isDoorOpen = false;
        internal static bool isCodeBroken = false;
        internal static bool isPortalOpen = false;



        string[] symbols = { "AU", "AG", "CU" };
        

        static void Shuffle(string[] Arr)
        {
            Random random = new Random();
            for (int i = 0; i < Arr.Length; i++)
            {
                int randNum = random.Next(3);

                string temp = Arr[i];
                Arr[i] = Arr[randNum];
                Arr[randNum] = temp;
                Console.Write(temp);
            }
        }






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
                    Console.WriteLine("The orb is ominous. [Seize] it ?");
                    

                    
                    break;
                case "imp":
                    Console.WriteLine("The imps look at you and start talking about the importance of GOLD compared to SILVER ");
                    break;
                case "snake":
                    Console.WriteLine("The snake is made out of bone only. It's murmuring about how SILVER is way cooler than COPPER");
                    break;
                case "river":
                    Console.WriteLine("A source of molten lava");
                    break;
                case "portal":
                    if (!isPortalOpen)
                    {
                        Console.WriteLine("You go through the shimmering energy...");
                        Game.Transition<Paradise>();
                        Game.currentRoom = new Paradise();

                    }
                    else
                    {
                        Console.WriteLine("Large and uncanny. The portal awaits an item for its circular [slot]");
                    }
                    
                    break;
                case "door":
                    if (!isDoorOpen)
                    {
                        if (Game.inventory.Contains("Bullet"))
                        {

                            Console.WriteLine("BOOM! The rock shatters! The corridor is open !");
                            isDoorOpen = true;
                        }
                        else
                        {
                            Console.WriteLine("There's a C4 on the wall");

                        }
                    }
                    else
                    {
                        Console.WriteLine("You go through the wide open door");
                        Game.Transition<Purgatory>();
                        Game.currentRoom = new Purgatory();
                    }
                    break;
                case "read":
                    Console.WriteLine("Huh... it's just gibberish! What the hell is " );
                    Shuffle(symbols);
                    
                    break;
                case "seize":

                    if (!isCodeBroken)
                    {

                        Console.WriteLine("You take the orb!");
                        Game.AddToInventory("Orb");
                    }
                    else
                    {
                        Console.WriteLine("Yeeowch!! It's stuck and it burns! You take 10 damage ?");
                        Game.hp -= 10;
                    }
                    
                    break;
                case "slot":
                    if (Game.inventory.Contains("Orb"))
                    {
                        Console.WriteLine("The portal opens up in a flash of energy! You're free to leave this hellscape! Finally!");
                        isPortalOpen = true;
                    }
                    else
                    {
                        Console.WriteLine("The slot is spherical.");
                    }
                    
                    break;
                case "auagcu":
                    Console.WriteLine("You say that word outloud, and the [orb] unlocks from it's pedestal!");    
                    break;  
                default:
                    Console.WriteLine("Invalid command.");
                    break;
                
            }
        }
    }
}
