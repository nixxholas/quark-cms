namespace Delta.Trinity.Characters
{
    public partial class BlackmarketAuctions
    {
        public int MarketId { get; set; }
        public long CurrentBid { get; set; }
        public int Time { get; set; }
        public int NumBids { get; set; }
        public long Bidder { get; set; }
    }
}
