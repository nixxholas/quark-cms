namespace Delta.Trinity.Characters
{
    public partial class GuildAchievementProgress
    {
        public long GuildId { get; set; }
        public int Criteria { get; set; }
        public long Counter { get; set; }
        public int Date { get; set; }
        public long CompletedGuid { get; set; }
    }
}
