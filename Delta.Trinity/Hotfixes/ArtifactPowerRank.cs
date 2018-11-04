namespace Delta.Trinity.Hotfixes
{
    public partial class ArtifactPowerRank
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public float AuraPointsOverride { get; set; }
        public short ItemBonusListId { get; set; }
        public byte RankIndex { get; set; }
        public short ArtifactPowerId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
