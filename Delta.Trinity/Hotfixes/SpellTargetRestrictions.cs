namespace Delta.Trinity.Hotfixes
{
    public partial class SpellTargetRestrictions
    {
        public int Id { get; set; }
        public float ConeDegrees { get; set; }
        public float Width { get; set; }
        public int Targets { get; set; }
        public short TargetCreatureType { get; set; }
        public byte DifficultyId { get; set; }
        public byte MaxTargets { get; set; }
        public int MaxTargetLevel { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
