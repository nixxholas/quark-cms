namespace Delta.Trinity.World
{
    public partial class CreatureText
    {
        public int CreatureId { get; set; }
        public byte GroupId { get; set; }
        public byte Id { get; set; }
        public string Text { get; set; }
        public byte Type { get; set; }
        public byte Language { get; set; }
        public float Probability { get; set; }
        public int Emote { get; set; }
        public int Duration { get; set; }
        public int Sound { get; set; }
        public int BroadcastTextId { get; set; }
        public byte TextRange { get; set; }
        public string Comment { get; set; }
    }
}
