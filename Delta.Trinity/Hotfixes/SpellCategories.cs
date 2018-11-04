namespace Delta.Trinity.Hotfixes
{
    public partial class SpellCategories
    {
        public int Id { get; set; }
        public short Category { get; set; }
        public short StartRecoveryCategory { get; set; }
        public short ChargeCategory { get; set; }
        public byte DifficultyId { get; set; }
        public byte DefenseType { get; set; }
        public byte DispelType { get; set; }
        public byte Mechanic { get; set; }
        public byte PreventionType { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
