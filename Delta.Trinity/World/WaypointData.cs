namespace Delta.Trinity.World
{
    public partial class WaypointData
    {
        public int Id { get; set; }
        public int Point { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public int Delay { get; set; }
        public int MoveType { get; set; }
        public int Action { get; set; }
        public short ActionChance { get; set; }
        public long Wpguid { get; set; }
    }
}
