namespace Delta.Trinity.Hotfixes
{
    public partial class CfgRegions
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public int Raidorigin { get; set; }
        public int ChallengeOrigin { get; set; }
        public short RegionId { get; set; }
        public byte RegionGroupMask { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
