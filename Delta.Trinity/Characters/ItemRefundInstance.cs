namespace Delta.Trinity.Characters
{
    public partial class ItemRefundInstance
    {
        public long ItemGuid { get; set; }
        public long PlayerGuid { get; set; }
        public long PaidMoney { get; set; }
        public short PaidExtendedCost { get; set; }
    }
}
