namespace Delta.Trinity.Hotfixes
{
    public partial class SpecializationSpells
    {
        public string Description { get; set; }
        public int SpellId { get; set; }
        public int OverridesSpellId { get; set; }
        public short SpecId { get; set; }
        public byte DisplayOrder { get; set; }
        public int Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
