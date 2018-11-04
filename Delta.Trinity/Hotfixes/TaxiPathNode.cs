namespace Delta.Trinity.Hotfixes
{
    public partial class TaxiPathNode
    {
        public float LocX { get; set; }
        public float LocY { get; set; }
        public float LocZ { get; set; }
        public short PathId { get; set; }
        public short ContinentId { get; set; }
        public byte NodeIndex { get; set; }
        public int Id { get; set; }
        public byte Flags { get; set; }
        public int Delay { get; set; }
        public short ArrivalEventId { get; set; }
        public short DepartureEventId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
