namespace Delta.Trinity.World
{
    public partial class QuestPoi
    {
        public int QuestId { get; set; }
        public int BlobIndex { get; set; }
        public int Idx1 { get; set; }
        public int ObjectiveIndex { get; set; }
        public int QuestObjectiveId { get; set; }
        public int QuestObjectId { get; set; }
        public int MapId { get; set; }
        public int WorldMapAreaId { get; set; }
        public int Floor { get; set; }
        public int Priority { get; set; }
        public int Flags { get; set; }
        public int WorldEffectId { get; set; }
        public int PlayerConditionId { get; set; }
        public int WoDunk1 { get; set; }
        public byte AlwaysAllowMergingBlobs { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
