namespace Delta.Trinity.Hotfixes
{
    public partial class PvpDifficulty
    {
        public int Id { get; set; }
        public byte RangeIndex { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public short MapId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
