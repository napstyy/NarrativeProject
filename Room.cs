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
    }
}
