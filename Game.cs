using NarrativeProject.Rooms;
using System;
using System.Collections.Generic;

namespace NarrativeProject
{
    internal class Game
    {
        List<Room> rooms = new List<Room>();
        public Room currentRoom;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextRoom = "";
        static List<string> inventory = new List<string>();


        internal void Add(Room room)
        {
            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
            }
        }

        internal string CurrentRoomDescription => currentRoom.CreateDescription();

        internal void ReceiveChoice(string choice)
        {
            if (choice == "i")
            {
                Console.WriteLine("Welcome to inventory");
                // Display inventory
                Console.WriteLine("Inventory:");
                foreach (var item in inventory)
                {
                    Console.WriteLine(item);
                }
            }
            else if (choice == "b")
            {
                // Transition to previous room if possible
                Transition<Room>();
            }
            else
            {
                currentRoom.ReceiveChoice(choice);
                CheckTransition();
            }
        }

        internal static void Transition<T>() where T : Room
        {
            nextRoom = typeof(T).Name;
        }

        

        internal static void Finish()
        {
            isFinished = true;
        }

        internal void CheckTransition()
        {
            foreach (var room in rooms)
            {
                if (room.GetType().Name == nextRoom)
                {
                    nextRoom = "";
                    currentRoom = room;
                    break;
                }
            }
        }


        public static void AddToInventory(string item)
        {
            inventory.Add(item);
        }







    }
}
