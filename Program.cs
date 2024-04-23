using NarrativeProject.Rooms;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace NarrativeProject
{
    public class Program
    {
       

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Corridor! This game has 3 endings! And many ways to die . . .");
            Thread.Sleep(3000);
            Console.WriteLine("You open your eyes");
            Thread.Sleep(3000);
            Console.WriteLine("Here we go again");
            Thread.Sleep(3000);


            var game = new Game();
            game.Add(new Corridor());
            game.Add(new Nature());
            game.Add(new Ocean());
            game.Add(new Hell());
            game.Add(new Purgatory());
            game.Add(new Paradise());



            


            while (!game.IsGameOver() && Game.hp > 0)
            {
                
                Console.WriteLine("--");
                Console.WriteLine("Current Health: "+ Game.hp);
                Console.WriteLine("--");
                Console.WriteLine("Open your inventory with [i]");
                Console.WriteLine("--");
                Console.WriteLine(game.CurrentRoomDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);


            }

            // this is for the room names
            string fullRoomName = Game.currentRoom.ToString();
            int lastIndex = fullRoomName.LastIndexOf('.') + 1;
            string roomName = fullRoomName.Substring(lastIndex);

            Console.WriteLine("You died in " + roomName);
            Console.ReadLine();


        }
    }


}
