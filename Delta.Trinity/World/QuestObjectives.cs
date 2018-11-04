namespace Delta.Trinity.World
{
    public partial class QuestObjectives
    {
        public int Id { get; set; }
        public int QuestId { get; set; }
        public byte Type { get; set; }
        public byte Order { get; set; }
        public byte StorageIndex { get; set; }
        public int ObjectId { get; set; }
        public int Amount { get; set; }
        public int Flags { get; set; }
        public int Flags2 { get; set; }
        public float ProgressBarWeight { get; set; }
        public string Description { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
