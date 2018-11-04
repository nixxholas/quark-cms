namespace Delta.Trinity.Characters
{
    public partial class CharacterVoidStorage
    {
        public long ItemId { get; set; }
        public long PlayerGuid { get; set; }
        public int ItemEntry { get; set; }
        public byte Slot { get; set; }
        public long CreatorGuid { get; set; }
        public byte RandomPropertyType { get; set; }
        public int RandomProperty { get; set; }
        public int SuffixFactor { get; set; }
        public int UpgradeId { get; set; }
        public int? FixedScalingLevel { get; set; }
        public int? ArtifactKnowledgeLevel { get; set; }
        public byte Context { get; set; }
        public string BonusListIds { get; set; }
    }
}
