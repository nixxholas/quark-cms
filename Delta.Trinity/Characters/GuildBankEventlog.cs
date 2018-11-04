namespace Delta.Trinity.Characters
{
    public partial class GuildBankEventlog
    {
        public long Guildid { get; set; }
        public int LogGuid { get; set; }
        public byte TabId { get; set; }
        public byte EventType { get; set; }
        public long PlayerGuid { get; set; }
        public long ItemOrMoney { get; set; }
        public short ItemStackCount { get; set; }
        public byte DestTabId { get; set; }
        public int TimeStamp { get; set; }
    }
}
