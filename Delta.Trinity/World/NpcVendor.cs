namespace Delta.Trinity.World
{
    public partial class NpcVendor
    {
        public int Entry { get; set; }
        public short Slot { get; set; }
        public int Item { get; set; }
        public int Maxcount { get; set; }
        public int Incrtime { get; set; }
        public int ExtendedCost { get; set; }
        public byte Type { get; set; }
        public string BonusListIds { get; set; }
        public int PlayerConditionId { get; set; }
        public byte IgnoreFiltering { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
