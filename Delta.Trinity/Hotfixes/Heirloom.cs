namespace Delta.Trinity.Hotfixes
{
    public partial class Heirloom
    {
        public string SourceText { get; set; }
        public int ItemId { get; set; }
        public int LegacyItemId { get; set; }
        public int LegacyUpgradedItemId { get; set; }
        public int StaticUpgradedItemId { get; set; }
        public int UpgradeItemId1 { get; set; }
        public int UpgradeItemId2 { get; set; }
        public int UpgradeItemId3 { get; set; }
        public short UpgradeItemBonusListId1 { get; set; }
        public short UpgradeItemBonusListId2 { get; set; }
        public short UpgradeItemBonusListId3 { get; set; }
        public byte Flags { get; set; }
        public byte SourceTypeEnum { get; set; }
        public int Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
