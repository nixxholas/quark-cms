namespace Delta.Trinity.Hotfixes
{
    public partial class GameobjectDisplayInfo
    {
        public int Id { get; set; }
        public int FileDataId { get; set; }
        public float GeoBoxMinX { get; set; }
        public float GeoBoxMinY { get; set; }
        public float GeoBoxMinZ { get; set; }
        public float GeoBoxMaxX { get; set; }
        public float GeoBoxMaxY { get; set; }
        public float GeoBoxMaxZ { get; set; }
        public float OverrideLootEffectScale { get; set; }
        public float OverrideNameScale { get; set; }
        public short ObjectEffectPackageId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
