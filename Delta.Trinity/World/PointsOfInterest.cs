namespace Delta.Trinity.World
{
    public partial class PointsOfInterest
    {
        public int Id { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public int Icon { get; set; }
        public int Flags { get; set; }
        public int Importance { get; set; }
        public string Name { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
