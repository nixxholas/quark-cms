namespace Delta.Trinity.Hotfixes
{
    public partial class ModifierTree
    {
        public int Id { get; set; }
        public int Asset { get; set; }
        public int SecondaryAsset { get; set; }
        public int Parent { get; set; }
        public byte Type { get; set; }
        public byte TertiaryAsset { get; set; }
        public byte Operator { get; set; }
        public byte Amount { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
