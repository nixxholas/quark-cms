namespace Delta.Trinity.World
{
    public partial class LfgDungeonTemplate
    {
        public int DungeonId { get; set; }
        public string Name { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public short RequiredItemLevel { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
