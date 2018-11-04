namespace Delta.Trinity.Hotfixes
{
    public partial class GarrPlot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AllianceConstructObjId { get; set; }
        public int HordeConstructObjId { get; set; }
        public byte UiCategoryId { get; set; }
        public byte PlotType { get; set; }
        public byte Flags { get; set; }
        public int UpgradeRequirement1 { get; set; }
        public int UpgradeRequirement2 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
