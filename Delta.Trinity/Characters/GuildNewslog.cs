namespace Delta.Trinity.Characters
{
    public partial class GuildNewslog
    {
        public long Guildid { get; set; }
        public int LogGuid { get; set; }
        public byte EventType { get; set; }
        public long PlayerGuid { get; set; }
        public int Flags { get; set; }
        public int Value { get; set; }
        public int TimeStamp { get; set; }
    }
}
