namespace Delta.Trinity.Characters
{
    public partial class CreatureRespawn
    {
        public long Guid { get; set; }
        public int RespawnTime { get; set; }
        public short MapId { get; set; }
        public int InstanceId { get; set; }
    }
}
