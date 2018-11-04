namespace Delta.Trinity.Hotfixes
{
    public partial class WorldMapOverlay
    {
        public string TextureName { get; set; }
        public int Id { get; set; }
        public short TextureWidth { get; set; }
        public short TextureHeight { get; set; }
        public int MapAreaId { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public int HitRectTop { get; set; }
        public int HitRectLeft { get; set; }
        public int HitRectBottom { get; set; }
        public int HitRectRight { get; set; }
        public int PlayerConditionId { get; set; }
        public int Flags { get; set; }
        public int AreaId1 { get; set; }
        public int AreaId2 { get; set; }
        public int AreaId3 { get; set; }
        public int AreaId4 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
