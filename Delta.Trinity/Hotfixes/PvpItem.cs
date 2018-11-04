namespace Delta.Trinity.Hotfixes
{
    public partial class PvpItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public byte ItemLevelDelta { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
