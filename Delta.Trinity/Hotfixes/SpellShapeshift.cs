namespace Delta.Trinity.Hotfixes
{
    public partial class SpellShapeshift
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public int ShapeshiftExclude1 { get; set; }
        public int ShapeshiftExclude2 { get; set; }
        public int ShapeshiftMask1 { get; set; }
        public int ShapeshiftMask2 { get; set; }
        public byte StanceBarOrder { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
