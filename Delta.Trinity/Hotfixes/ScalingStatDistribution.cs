namespace Delta.Trinity.Hotfixes
{
    public partial class ScalingStatDistribution
    {
        public int Id { get; set; }
        public short PlayerLevelToItemLevelCurveId { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
