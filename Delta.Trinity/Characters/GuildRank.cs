namespace Delta.Trinity.Characters
{
    public partial class GuildRank
    {
        public long Guildid { get; set; }
        public byte Rid { get; set; }
        public string Rname { get; set; }
        public int Rights { get; set; }
        public int BankMoneyPerDay { get; set; }
    }
}
