namespace Delta.Trinity.Hotfixes
{
    public partial class SpellScaling
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public short ScalesFromItemLevel { get; set; }
        public int Class { get; set; }
        public int MinScalingLevel { get; set; }
        public int MaxScalingLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
