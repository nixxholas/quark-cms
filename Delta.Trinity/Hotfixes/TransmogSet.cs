namespace Delta.Trinity.Hotfixes
{
    public partial class TransmogSet
    {
        public string Name { get; set; }
        public short ParentTransmogSetId { get; set; }
        public short UiOrder { get; set; }
        public byte ExpansionId { get; set; }
        public int Id { get; set; }
        public int Flags { get; set; }
        public int TrackingQuestId { get; set; }
        public int ClassMask { get; set; }
        public int ItemNameDescriptionId { get; set; }
        public int TransmogSetGroupId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
