namespace Delta.Trinity.Hotfixes
{
    public partial class WorldMapTransforms
    {
        public int Id { get; set; }
        public float RegionMinX { get; set; }
        public float RegionMinY { get; set; }
        public float RegionMinZ { get; set; }
        public float RegionMaxX { get; set; }
        public float RegionMaxY { get; set; }
        public float RegionMaxZ { get; set; }
        public float RegionOffsetX { get; set; }
        public float RegionOffsetY { get; set; }
        public float RegionScale { get; set; }
        public short MapId { get; set; }
        public short AreaId { get; set; }
        public short NewMapId { get; set; }
        public short NewDungeonMapId { get; set; }
        public short NewAreaId { get; set; }
        public byte Flags { get; set; }
        public int Priority { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
