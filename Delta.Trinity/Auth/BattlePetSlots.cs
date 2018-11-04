namespace Delta.Trinity.Auth
{
    public partial class BattlePetSlots
    {
        public byte Id { get; set; }
        public int BattlenetAccountId { get; set; }
        public long BattlePetGuid { get; set; }
        public byte Locked { get; set; }
    }
}
