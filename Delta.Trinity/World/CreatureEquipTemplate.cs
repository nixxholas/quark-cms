namespace Delta.Trinity.World
{
    public partial class CreatureEquipTemplate
    {
        public int CreatureId { get; set; }
        public byte Id { get; set; }
        public int ItemId1 { get; set; }
        public short AppearanceModId1 { get; set; }
        public short ItemVisual1 { get; set; }
        public int ItemId2 { get; set; }
        public short AppearanceModId2 { get; set; }
        public short ItemVisual2 { get; set; }
        public int ItemId3 { get; set; }
        public short AppearanceModId3 { get; set; }
        public short ItemVisual3 { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
