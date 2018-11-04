namespace Delta.Trinity.Hotfixes
{
    public partial class QuestPackageItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public short PackageId { get; set; }
        public byte DisplayType { get; set; }
        public int ItemQuantity { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
