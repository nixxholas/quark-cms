namespace Delta.Trinity.Hotfixes
{
    public partial class PvpTalent
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int SpellId { get; set; }
        public int OverridesSpellId { get; set; }
        public int ActionBarSpellId { get; set; }
        public int TierId { get; set; }
        public int ColumnIndex { get; set; }
        public int Flags { get; set; }
        public int ClassId { get; set; }
        public int SpecId { get; set; }
        public int Role { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
