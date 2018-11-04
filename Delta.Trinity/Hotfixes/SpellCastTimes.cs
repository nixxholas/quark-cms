namespace Delta.Trinity.Hotfixes
{
    public partial class SpellCastTimes
    {
        public int Id { get; set; }
        public int Base { get; set; }
        public int Minimum { get; set; }
        public short PerLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
