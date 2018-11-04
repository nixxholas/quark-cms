namespace Delta.Trinity.Hotfixes
{
    public partial class TransportAnimation
    {
        public int Id { get; set; }
        public int TimeIndex { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public byte SequenceId { get; set; }
        public int TransportId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
