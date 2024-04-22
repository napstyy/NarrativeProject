using NarrativeProject.Rooms;
using System;

namespace NarrativeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Add(new Corridor());
            game.Add(new Hell());
            game.Add(new Nature());
            game.Add(new Ocean());
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
