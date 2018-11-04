namespace Delta.Trinity.Hotfixes
{
    public partial class ItemBonus
    {
        public int Id { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Value3 { get; set; }
        public short ParentItemBonusListId { get; set; }
        public byte Type { get; set; }
        public byte OrderIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
