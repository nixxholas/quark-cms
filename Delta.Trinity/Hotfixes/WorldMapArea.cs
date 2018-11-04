namespace Delta.Trinity.Hotfixes
{
    public partial class WorldMapArea
    {
        public string AreaName { get; set; }
        public float LocLeft { get; set; }
        public float LocRight { get; set; }
        public float LocTop { get; set; }
        public float LocBottom { get; set; }
        public int Flags { get; set; }
        public short MapId { get; set; }
        public short AreaId { get; set; }
        public short DisplayMapId { get; set; }
        public short DefaultDungeonFloor { get; set; }
        public short ParentWorldMapId { get; set; }
        public byte LevelRangeMin { get; set; }
        public byte LevelRangeMax { get; set; }
        public byte BountySetId { get; set; }
        public byte BountyDisplayLocation { get; set; }
        public int Id { get; set; }
        public int VisibilityPlayerConditionId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
