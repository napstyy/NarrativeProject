﻿using System;
using System.Collections.Generic;

namespace NarrativeProject.Rooms
{
    internal class Corridor : Room
    {
       
       
        

        

        internal static bool isBombCollected = false;

        internal static bool isNatureOpen = false;
        internal static bool isOceanOpen = false;
        internal static bool isHellOpen = false;









        internal static int timesEnteredNature = 0;


        internal override string CreateDescription() =>
@"You're in a large corridor
--------------------------------------------
There are large columns and an eerie yellow light coming from torches
--------------------------------------------
There is a [wolf] man leaning on a column
--------------------------------------------
There is a [nature] door, covered in plants and vines
--------------------------------------------
There is an [ocean] door, covered in sea shells and sand
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
                case "wolf":
                        Console.WriteLine("Just say my name followed by a door, i'll tell you what i know, heh..");                    
                    break;
                case "wolf nature":
                    Console.WriteLine("Watch out for the bear in there, he likes to eat fish in bulk! Get him like 5 or 6 of those");
                    break;
                case "wolf ocean":
                    Console.WriteLine("Saw the bird in there carrying something important..");
                    break;
                case "wolf hell":
                    Console.WriteLine("Never could understand what the imps were tryin to tell me");
                    break;
                case "wolf corridor":
                    Console.WriteLine("Nothing here. Just you and me, in purgatory");
                    break;
                case "nature":
                    if (!isNatureOpen)
                    {
                        if (Game.inventory.Contains("Handsaw"))
                        {
                            
                            Console.WriteLine("You cut right through the vines thanks to the saw! You can now go through the [nature] door");
                            isNatureOpen = true;
                        }
                        else
                        {
                            Console.WriteLine("The nature door won't budge. The thorns and vines need to be cut");

                        }
                    }
                    else
                    {
                        Console.WriteLine("You go through the wide open Nature door");
                        Game.Transition<Nature>();
                        Game.currentRoom = new Nature();
                        timesEnteredNature++;
                    }
                    
                    break;
                case "ocean":
                    if (!isOceanOpen)
                    {
                        if (Game.inventory.Contains("Hammer"))
                        {
                            
                            Console.WriteLine("You smash the shells to bits thanks to the hammer! You can now go through the [ocean] door");
                            isOceanOpen = true;
                        }
                        else
                        {
                            Console.WriteLine("The ocean door won't move. The hard shells would need to be smashed open");

                        }
                    }
                    else
                    {
                        Console.WriteLine("You go through the wide open Ocean door");
                        Game.Transition<Ocean>();
                        Game.currentRoom = new Ocean();
                    }
                    break;
                case "hell":
                    if (!isHellOpen)
                    {
                        if (Game.inventory.Contains("Suit"))
                        {
                            
                            Console.WriteLine("You got a heatproof suit on! You feel confident enough to go through the [hell] door");
                            isHellOpen = true;
                        }
                        else
                        {
                            Console.WriteLine("It's not even a door, just a constant stream of lava, like a waterfall");

                        }
                    }
                    else
                    {
                        Console.WriteLine("You go through the curtain of lava");
                        Game.Transition<Hell>();
                        Game.currentRoom = new Hell();
                    }
                    break;
                case "carpet":
                    Console.WriteLine("The carpet looks fancy. It never seems to end. You notice a [bump]");
                    break;
                case "mirror":
                    Console.WriteLine("It's you! The wolf man is right behind. He's looking to the [side], sulking");
                    break;
                case "bump":
                    Console.WriteLine("You dig your hands under the carpet. Ah! this is a handsaw!");
                    Game.AddToInventory("Handsaw");
                    
                    break;
                case "side":
                    Console.WriteLine("He's looking at the void. Nothing too interesting out there");
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
