namespace Delta.Trinity.World
{
    public partial class GameEventQuestCondition
    {
        public byte EventEntry { get; set; }
        public int Quest { get; set; }
        public int ConditionId { get; set; }
        public float? Num { get; set; }
    }
}
