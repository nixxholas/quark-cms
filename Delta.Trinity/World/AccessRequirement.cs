namespace Delta.Trinity.World
{
    public partial class AccessRequirement
    {
        public int MapId { get; set; }
        public byte Difficulty { get; set; }
        public byte LevelMin { get; set; }
        public byte LevelMax { get; set; }
        public int Item { get; set; }
        public int Item2 { get; set; }
        public int QuestDoneA { get; set; }
        public int QuestDoneH { get; set; }
        public int CompletedAchievement { get; set; }
        public string QuestFailedText { get; set; }
        public string Comment { get; set; }
    }
}
