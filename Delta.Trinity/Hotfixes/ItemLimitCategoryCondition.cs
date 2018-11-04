namespace Delta.Trinity.Hotfixes
{
    public partial class ItemLimitCategoryCondition
    {
        public int Id { get; set; }
        public byte AddQuantity { get; set; }
        public int PlayerConditionId { get; set; }
        public int ParentItemLimitCategoryId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
