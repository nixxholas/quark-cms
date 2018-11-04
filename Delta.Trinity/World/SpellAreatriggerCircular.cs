namespace Delta.Trinity.World
{
    public partial class SpellAreatriggerCircular
    {
        public int SpellMiscId { get; set; }
        public int StartDelay { get; set; }
        public float CircleRadius { get; set; }
        public float BlendFromRadius { get; set; }
        public float InitialAngle { get; set; }
        public float Zoffset { get; set; }
        public byte CounterClockwise { get; set; }
        public byte CanLoop { get; set; }
        public int VerifiedBuild { get; set; }
    }
}
