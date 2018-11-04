namespace Delta.Trinity.Hotfixes
{
    public partial class ArtifactUnlock
    {
        public int Id { get; set; }
        public short ItemBonusListId { get; set; }
        public byte PowerRank { get; set; }
        public int PowerId { get; set; }
        public int PlayerConditionId { get; set; }
        public byte ArtifactId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
