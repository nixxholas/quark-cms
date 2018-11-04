namespace Delta.Trinity.Hotfixes
{
    public partial class RulesetItemUpgrade
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public short ItemUpgradeId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
