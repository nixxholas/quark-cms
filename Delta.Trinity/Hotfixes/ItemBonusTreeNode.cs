namespace Delta.Trinity.Hotfixes
{
    public partial class ItemBonusTreeNode
    {
        public int Id { get; set; }
        public short ChildItemBonusTreeId { get; set; }
        public short ChildItemBonusListId { get; set; }
        public short ChildItemLevelSelectorId { get; set; }
        public byte ItemContext { get; set; }
        public short ParentItemBonusTreeId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
