namespace Delta.Trinity.Hotfixes
{
    public partial class SpellAuraOptions
    {
        public int Id { get; set; }
        public int ProcCharges { get; set; }
        public int ProcTypeMask { get; set; }
        public int ProcCategoryRecovery { get; set; }
        public short CumulativeAura { get; set; }
        public short SpellProcsPerMinuteId { get; set; }
        public byte DifficultyId { get; set; }
        public byte ProcChance { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
