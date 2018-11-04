namespace Delta.Trinity.Hotfixes
{
    public partial class ItemLevelSelectorQuality
    {
        public int Id { get; set; }
        public int QualityItemBonusListId { get; set; }
        public byte Quality { get; set; }
        public short ParentIlsqualitySetId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
