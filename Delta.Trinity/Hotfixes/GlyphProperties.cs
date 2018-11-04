namespace Delta.Trinity.Hotfixes
{
    public partial class GlyphProperties
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public short SpellIconId { get; set; }
        public byte GlyphType { get; set; }
        public byte GlyphExclusiveCategoryId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
