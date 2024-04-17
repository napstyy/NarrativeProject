using NarrativeProject.Rooms;
using System;

namespace NarrativeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Add(new Corridor(game));
            game.Add(new Hell());
            game.Add(new Nature());
            game.Add(new Inventory());
            game.Add(new Ocean());
            game.Add(new Paradise());


            while (!game.IsGameOver())
            {
                Console.WriteLine("--");
                Console.WriteLine("Open your inventory with [i]");
                Console.WriteLine(game.CurrentRoomDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
            }

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
