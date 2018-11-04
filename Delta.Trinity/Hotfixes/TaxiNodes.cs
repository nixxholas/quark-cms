namespace Delta.Trinity.Hotfixes
{
    public partial class TaxiNodes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public int MountCreatureId1 { get; set; }
        public int MountCreatureId2 { get; set; }
        public float MapOffsetX { get; set; }
        public float MapOffsetY { get; set; }
        public float Facing { get; set; }
        public float FlightMapOffsetX { get; set; }
        public float FlightMapOffsetY { get; set; }
        public short ContinentId { get; set; }
        public short ConditionId { get; set; }
        public short CharacterBitNumber { get; set; }
        public byte Flags { get; set; }
        public int UiTextureKitId { get; set; }
        public int SpecialIconConditionId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
