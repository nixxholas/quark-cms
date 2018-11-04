namespace Delta.Trinity.World
{
    public partial class QuestObjectivesLocale
    {
        public int Id { get; set; }
        public string Locale { get; set; }
        public int QuestId { get; set; }
        public byte StorageIndex { get; set; }
        public string Description { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
