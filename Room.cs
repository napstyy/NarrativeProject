namespace NarrativeProject
{
    internal abstract class Room
    {

        internal abstract int id { get; }
        internal abstract string CreateDescription();
        internal abstract void ReceiveChoice(string choice);
    }
}
