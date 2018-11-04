namespace Delta.Trinity.Hotfixes
{
    public partial class Creature
    {
        public int Id { get; set; }
        public int ItemId1 { get; set; }
        public int ItemId2 { get; set; }
        public int ItemId3 { get; set; }
        public int Mount { get; set; }
        public int DisplayId1 { get; set; }
        public int DisplayId2 { get; set; }
        public int DisplayId3 { get; set; }
        public int DisplayId4 { get; set; }
        public float DisplayIdprobability1 { get; set; }
        public float DisplayIdprobability2 { get; set; }
        public float DisplayIdprobability3 { get; set; }
        public float DisplayIdprobability4 { get; set; }
        public string Name { get; set; }
        public string FemaleName { get; set; }
        public string SubName { get; set; }
        public string FemaleSubName { get; set; }
        public int Type { get; set; }
        public byte Family { get; set; }
        public byte Classification { get; set; }
        public byte InhabitType { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
