namespace Delta.Trinity.Hotfixes
{
    public partial class ItemUpgrade
    {
        public int Id { get; set; }
        public int CurrencyAmount { get; set; }
        public short PrerequisiteId { get; set; }
        public short CurrencyType { get; set; }
        public byte ItemUpgradePathId { get; set; }
        public byte ItemLevelIncrement { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
