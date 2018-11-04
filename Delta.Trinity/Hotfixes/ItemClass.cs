namespace Delta.Trinity.Hotfixes
{
    public partial class ItemClass
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public float PriceModifier { get; set; }
        public byte ClassId { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
