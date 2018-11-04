namespace Delta.Trinity.Hotfixes
{
    public partial class SpellEquippedItems
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public int EquippedItemInvTypes { get; set; }
        public int EquippedItemSubclass { get; set; }
        public byte EquippedItemClass { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
