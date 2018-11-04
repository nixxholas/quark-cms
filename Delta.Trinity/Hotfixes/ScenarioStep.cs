namespace Delta.Trinity.Hotfixes
{
    public partial class ScenarioStep
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public short ScenarioId { get; set; }
        public short Supersedes { get; set; }
        public short RewardQuestId { get; set; }
        public byte OrderIndex { get; set; }
        public byte Flags { get; set; }
        public int Criteriatreeid { get; set; }
        public int RelatedStep { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
