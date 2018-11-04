namespace Delta.Trinity.Hotfixes
{
    public partial class CurvePoint
    {
        public int Id { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public short CurveId { get; set; }
        public byte OrderIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
