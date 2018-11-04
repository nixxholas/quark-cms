namespace Delta.Trinity.Characters
{
    public partial class ItemLootItems
    {
        public long ContainerId { get; set; }
        public int ItemId { get; set; }
        public int ItemCount { get; set; }
        public byte FollowRules { get; set; }
        public byte Ffa { get; set; }
        public byte Blocked { get; set; }
        public byte Counted { get; set; }
        public byte UnderThreshold { get; set; }
        public byte NeedsQuest { get; set; }
        public byte RndType { get; set; }
        public int RndProp { get; set; }
        public int RndSuffix { get; set; }
        public byte Context { get; set; }
        public string BonusListIds { get; set; }
    }
}
