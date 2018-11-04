namespace Delta.Trinity.Hotfixes
{
    public partial class AuctionHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short FactionId { get; set; }
        public byte DepositRate { get; set; }
        public byte ConsignmentRate { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
