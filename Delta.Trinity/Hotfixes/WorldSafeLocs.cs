namespace Delta.Trinity.Hotfixes
{
    public partial class WorldSafeLocs
    {
        public int Id { get; set; }
        public string AreaName { get; set; }
        public float LocX { get; set; }
        public float LocY { get; set; }
        public float LocZ { get; set; }
        public float Facing { get; set; }
        public short MapId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
