namespace Delta.Trinity.Hotfixes
{
    public partial class SpellRadius
    {
        public int Id { get; set; }
        public float Radius { get; set; }
        public float RadiusPerLevel { get; set; }
        public float RadiusMin { get; set; }
        public float RadiusMax { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
