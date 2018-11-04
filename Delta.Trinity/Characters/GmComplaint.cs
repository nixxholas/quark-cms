namespace Delta.Trinity.Characters
{
    public partial class GmComplaint
    {
        public int Id { get; set; }
        public long PlayerGuid { get; set; }
        public string Note { get; set; }
        public int CreateTime { get; set; }
        public short MapId { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float Facing { get; set; }
        public long TargetCharacterGuid { get; set; }
        public short ComplaintType { get; set; }
        public int ReportLineIndex { get; set; }
        public long ClosedBy { get; set; }
        public long AssignedTo { get; set; }
        public string Comment { get; set; }
    }
}
