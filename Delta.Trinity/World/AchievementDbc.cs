namespace Delta.Trinity.World
{
    public partial class AchievementDbc
    {
        public int Id { get; set; }
        public int RequiredFaction { get; set; }
        public int MapId { get; set; }
        public int Points { get; set; }
        public int Flags { get; set; }
        public int Count { get; set; }
        public int RefAchievement { get; set; }
    }
}
