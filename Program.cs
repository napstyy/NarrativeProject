using NarrativeProject.Rooms;
using System;
using System.Security.Cryptography.X509Certificates;

namespace NarrativeProject
{
    public class Program
    {
       
        public virtual void gameDone()
        {
            // this is for the room names
            string fullRoomName = Game.currentRoom.ToString();
            int lastIndex = fullRoomName.LastIndexOf('.') + 1;
            string roomName = fullRoomName.Substring(lastIndex);

            Console.WriteLine("You died in " + roomName);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
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



            
        }
    }
    public class Program2 : Program
    {
        public override void gameDone()
        {
            for (int i = 0; i < 5000; i++)
            {
                Console.WriteLine("YOU WIN");
            }
  
            Console.ReadLine();
        }
    }


}
