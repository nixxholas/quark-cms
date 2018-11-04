namespace Delta.Trinity.World
{
    public partial class GameEventCondition
    {
        public byte EventEntry { get; set; }
        public int ConditionId { get; set; }
        public float? ReqNum { get; set; }
        public short MaxWorldStateField { get; set; }
        public short DoneWorldStateField { get; set; }
        public string Description { get; set; }
    }
}
