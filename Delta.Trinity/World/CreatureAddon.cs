namespace Delta.Trinity.World
{
    public partial class CreatureAddon
    {
        public long Guid { get; set; }
        public int PathId { get; set; }
        public int Mount { get; set; }
        public int Bytes1 { get; set; }
        public int Bytes2 { get; set; }
        public int Emote { get; set; }
        public short AiAnimKit { get; set; }
        public short MovementAnimKit { get; set; }
        public short MeleeAnimKit { get; set; }
        public string Auras { get; set; }
    }
}
