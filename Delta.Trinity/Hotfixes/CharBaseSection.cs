namespace Delta.Trinity.Hotfixes
{
    public partial class CharBaseSection
    {
        public int Id { get; set; }
        public byte VariationEnum { get; set; }
        public byte ResolutionVariationEnum { get; set; }
        public byte LayoutResType { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
