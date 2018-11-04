namespace Delta.Trinity.Hotfixes
{
    public partial class SpellXSpellVisual
    {
        public int SpellVisualId { get; set; }
        public int Id { get; set; }
        public float Probability { get; set; }
        public short CasterPlayerConditionId { get; set; }
        public short CasterUnitConditionId { get; set; }
        public short ViewerPlayerConditionId { get; set; }
        public short ViewerUnitConditionId { get; set; }
        public int SpellIconFileId { get; set; }
        public int ActiveIconFileId { get; set; }
        public byte Flags { get; set; }
        public byte DifficultyId { get; set; }
        public byte Priority { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
