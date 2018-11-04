namespace Delta.Trinity.Hotfixes
{
    public partial class Achievement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Reward { get; set; }
        public int Flags { get; set; }
        public short InstanceId { get; set; }
        public short Supercedes { get; set; }
        public short Category { get; set; }
        public short UiOrder { get; set; }
        public short SharesCriteria { get; set; }
        public byte Faction { get; set; }
        public byte Points { get; set; }
        public byte MinimumCriteria { get; set; }
        public int Id { get; set; }
        public int IconFileId { get; set; }
        public int CriteriaTree { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
