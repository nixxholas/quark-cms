namespace Delta.Trinity.Hotfixes
{
    public partial class ItemEffect
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public int CoolDownMsec { get; set; }
        public int CategoryCoolDownMsec { get; set; }
        public short Charges { get; set; }
        public short SpellCategoryId { get; set; }
        public short ChrSpecializationId { get; set; }
        public byte LegacySlotIndex { get; set; }
        public byte TriggerType { get; set; }
        public int ParentItemId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
