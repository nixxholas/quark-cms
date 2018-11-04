namespace Delta.Trinity.Hotfixes
{
    public partial class SpellAuraRestrictions
    {
        public int Id { get; set; }
        public int CasterAuraSpell { get; set; }
        public int TargetAuraSpell { get; set; }
        public int ExcludeCasterAuraSpell { get; set; }
        public int ExcludeTargetAuraSpell { get; set; }
        public byte DifficultyId { get; set; }
        public byte CasterAuraState { get; set; }
        public byte TargetAuraState { get; set; }
        public byte ExcludeCasterAuraState { get; set; }
        public byte ExcludeTargetAuraState { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
