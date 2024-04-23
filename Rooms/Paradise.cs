using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace NarrativeProject.Rooms
{
    internal class Paradise : Room
    {

        public override void gameDone()
        {
            for (int i = 0; i < 5000; i++)
            {
                Console.WriteLine("YOU WIN");
            }

            Console.ReadLine();
        }



        public enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Purple,
            Orange
        }

        static bool isPuzzleFailed = false;


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
                    if (isPuzzleFailed)
                    {
                        Console.WriteLine("The angel is placid. You feel you can't get anything else out of it");
                    }
                    else
                    {
                        Console.WriteLine("Be not afraid");
                        Console.WriteLine("To prove your worthiness, you must solve the puzzle. Paint with the colors in front of you to reach paradise");
                        Console.WriteLine("A color for Blood");
                        Console.WriteLine("A color for Gold");
                        Console.WriteLine("A color for the Sky");
                        Console.WriteLine("You see the following colors: ");


                        Console.WriteLine("Enter three colors separated by spaces:Red, Green, Blue, Yellow, Purple, Orange ");
                        string input = Console.ReadLine();
                        if (input == "red yellow blue")
                        {
                            Console.WriteLine("The colors mix together into white. The angel looks happy. It covers you in light");
                            gameDone();
                            Game.isFinished = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The colors mix . . . into a dark puddle. The angel isn't mad, just disappointed.");
                            isPuzzleFailed = true;
                            
                        }
                    }
                    
                    break;
                case "rest":
                    
                    Console.Clear();
                    Console.WriteLine("You let go . . . It feels good . . . Goodnight . . .");
                    Thread.Sleep(3000);
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
