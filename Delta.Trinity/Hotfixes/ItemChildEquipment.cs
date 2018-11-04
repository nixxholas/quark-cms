namespace Delta.Trinity.Hotfixes
{
    public partial class ItemChildEquipment
    {
        public int Id { get; set; }
        public int ChildItemId { get; set; }
        public byte ChildItemEquipSlot { get; set; }
        public int ParentItemId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
