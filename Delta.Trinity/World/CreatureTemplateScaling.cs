namespace Delta.Trinity.World
{
    public partial class CreatureTemplateScaling
    {
        public int Entry { get; set; }
        public short LevelScalingMin { get; set; }
        public short LevelScalingMax { get; set; }
        public short LevelScalingDeltaMin { get; set; }
        public short LevelScalingDeltaMax { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
