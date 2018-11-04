namespace Delta.Trinity.World
{
    public partial class VehicleAccessory
    {
        public long Guid { get; set; }
        public int AccessoryEntry { get; set; }
        public byte SeatId { get; set; }
        public byte Minion { get; set; }
        public string Description { get; set; }
        public byte Summontype { get; set; }
        public int Summontimer { get; set; }
    }
}
