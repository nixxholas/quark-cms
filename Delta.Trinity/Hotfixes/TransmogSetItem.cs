namespace Delta.Trinity.Hotfixes
{
    public partial class TransmogSetItem
    {
        public int Id { get; set; }
        public int TransmogSetId { get; set; }
        public int ItemModifiedAppearanceId { get; set; }
        public int Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
