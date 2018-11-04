namespace Delta.Trinity.Hotfixes
{
    public partial class ItemModifiedAppearance
    {
        public int ItemId { get; set; }
        public int Id { get; set; }
        public byte ItemAppearanceModifierId { get; set; }
        public short ItemAppearanceId { get; set; }
        public byte OrderIndex { get; set; }
        public byte TransmogSourceTypeEnum { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
