namespace Delta.Trinity.Hotfixes
{
    public partial class ItemLimitCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Quantity { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
