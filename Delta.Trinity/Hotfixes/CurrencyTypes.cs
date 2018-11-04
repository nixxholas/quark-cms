namespace Delta.Trinity.Hotfixes
{
    public partial class CurrencyTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxQty { get; set; }
        public int MaxEarnablePerWeek { get; set; }
        public int Flags { get; set; }
        public byte CategoryId { get; set; }
        public byte SpellCategory { get; set; }
        public byte Quality { get; set; }
        public int InventoryIconFileId { get; set; }
        public int SpellWeight { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
