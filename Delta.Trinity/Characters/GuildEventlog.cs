namespace Delta.Trinity.Characters
{
    public partial class GuildEventlog
    {
        public long Guildid { get; set; }
        public int LogGuid { get; set; }
        public byte EventType { get; set; }
        public long PlayerGuid1 { get; set; }
        public long PlayerGuid2 { get; set; }
        public byte NewRank { get; set; }
        public int TimeStamp { get; set; }
    }
}
