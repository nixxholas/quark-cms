namespace Delta.Trinity.Characters
{
    public partial class GameEventSave
    {
        public byte EventEntry { get; set; }
        public byte State { get; set; }
        public int NextStart { get; set; }
    }
}
