namespace Delta.Trinity.Hotfixes
{
    public partial class RewardPack
    {
        public int Id { get; set; }
        public int Money { get; set; }
        public float ArtifactXpmultiplier { get; set; }
        public byte ArtifactXpdifficulty { get; set; }
        public byte ArtifactXpcategoryId { get; set; }
        public int CharTitleId { get; set; }
        public int TreasurePickerId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
