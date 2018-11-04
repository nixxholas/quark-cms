namespace Delta.Trinity.Hotfixes
{
    public partial class Talent
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int SpellId { get; set; }
        public int OverridesSpellId { get; set; }
        public short SpecId { get; set; }
        public byte TierId { get; set; }
        public byte ColumnIndex { get; set; }
        public byte Flags { get; set; }
        public byte CategoryMask1 { get; set; }
        public byte CategoryMask2 { get; set; }
        public byte ClassId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
