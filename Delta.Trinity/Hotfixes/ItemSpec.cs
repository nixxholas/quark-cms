namespace Delta.Trinity.Hotfixes
{
    public partial class ItemSpec
    {
        public int Id { get; set; }
        public short SpecializationId { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public byte ItemType { get; set; }
        public byte PrimaryStat { get; set; }
        public byte SecondaryStat { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
