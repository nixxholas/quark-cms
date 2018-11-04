namespace Delta.Trinity.Hotfixes
{
    public partial class ItemAppearance
    {
        public int Id { get; set; }
        public int ItemDisplayInfoId { get; set; }
        public int DefaultIconFileDataId { get; set; }
        public int UiOrder { get; set; }
        public byte DisplayType { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
