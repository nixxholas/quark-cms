namespace Delta.Trinity.Hotfixes
{
    public partial class CharSections
    {
        public int Id { get; set; }
        public int MaterialResourcesId1 { get; set; }
        public int MaterialResourcesId2 { get; set; }
        public int MaterialResourcesId3 { get; set; }
        public short Flags { get; set; }
        public byte RaceId { get; set; }
        public byte SexId { get; set; }
        public byte BaseSection { get; set; }
        public byte VariationIndex { get; set; }
        public byte ColorIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
