namespace Delta.Trinity.World
{
    public partial class PlayerchoiceResponseReward
    {
        public int ChoiceId { get; set; }
        public int ResponseId { get; set; }
        public int TitleId { get; set; }
        public int PackageId { get; set; }
        public int SkillLineId { get; set; }
        public int SkillPointCount { get; set; }
        public int ArenaPointCount { get; set; }
        public int HonorPointCount { get; set; }
        public long Money { get; set; }
        public int Xp { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
