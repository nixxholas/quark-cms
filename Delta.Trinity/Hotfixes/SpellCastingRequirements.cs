namespace Delta.Trinity.Hotfixes
{
    public partial class SpellCastingRequirements
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public short MinFactionId { get; set; }
        public short RequiredAreasId { get; set; }
        public short RequiresSpellFocus { get; set; }
        public byte FacingCasterFlags { get; set; }
        public byte MinReputation { get; set; }
        public byte RequiredAuraVision { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
