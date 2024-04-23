using System;

namespace NarrativeProject
{
    internal abstract class Room
    {

        public string GetName()
        {
           
            string roomName = GetType().Name;
            return roomName;
        }
        internal abstract string CreateDescription();
        internal abstract void ReceiveChoice(string choice);



        public virtual void gameDone()
        {
            // this is for the room names
            string fullRoomName = Game.currentRoom.ToString();
            int lastIndex = fullRoomName.LastIndexOf('.') + 1;
            string roomName = fullRoomName.Substring(lastIndex);

            Console.WriteLine("You died in " + roomName);
            Console.ReadLine();
        }

    }
}
