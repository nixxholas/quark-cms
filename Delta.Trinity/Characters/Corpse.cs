namespace Delta.Trinity.Characters
{
    public partial class Corpse
    {
        public long Guid { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float Orientation { get; set; }
        public short MapId { get; set; }
        public int DisplayId { get; set; }
        public string ItemCache { get; set; }
        public int Bytes1 { get; set; }
        public int Bytes2 { get; set; }
        public byte Flags { get; set; }
        public byte DynFlags { get; set; }
        public int Time { get; set; }
        public byte CorpseType { get; set; }
        public int InstanceId { get; set; }
    }
}
