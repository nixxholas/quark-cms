namespace Delta.Trinity.World
{
    public partial class Creature
    {
        public long Guid { get; set; }
        public int Id { get; set; }
        public short Map { get; set; }
        public short ZoneId { get; set; }
        public short AreaId { get; set; }
        public string SpawnDifficulties { get; set; }
        public byte PhaseUseFlags { get; set; }
        public int? PhaseId { get; set; }
        public int? PhaseGroup { get; set; }
        public int TerrainSwapMap { get; set; }
        public int Modelid { get; set; }
        public byte EquipmentId { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public int Spawntimesecs { get; set; }
        public float Spawndist { get; set; }
        public int Currentwaypoint { get; set; }
        public int Curhealth { get; set; }
        public int Curmana { get; set; }
        public byte MovementType { get; set; }
        public long Npcflag { get; set; }
        public int UnitFlags { get; set; }
        public int UnitFlags2 { get; set; }
        public int UnitFlags3 { get; set; }
        public int Dynamicflags { get; set; }
        public string ScriptName { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
