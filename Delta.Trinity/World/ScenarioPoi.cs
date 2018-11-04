namespace Delta.Trinity.World
{
    public partial class ScenarioPoi
    {
        public int CriteriaTreeId { get; set; }
        public int BlobIndex { get; set; }
        public int Idx1 { get; set; }
        public int MapId { get; set; }
        public int WorldMapAreaId { get; set; }
        public int Floor { get; set; }
        public int Priority { get; set; }
        public int Flags { get; set; }
        public int WorldEffectId { get; set; }
        public int PlayerConditionId { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
