namespace Delta.Trinity.Hotfixes
{
    public partial class AreaTrigger
    {
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float Radius { get; set; }
        public float BoxLength { get; set; }
        public float BoxWidth { get; set; }
        public float BoxHeight { get; set; }
        public float BoxYaw { get; set; }
        public short ContinentId { get; set; }
        public short PhaseId { get; set; }
        public short PhaseGroupId { get; set; }
        public short ShapeId { get; set; }
        public short AreaTriggerActionSetId { get; set; }
        public byte PhaseUseFlags { get; set; }
        public byte ShapeType { get; set; }
        public byte Flags { get; set; }
        public int Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
