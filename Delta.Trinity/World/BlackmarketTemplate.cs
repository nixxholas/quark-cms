namespace Delta.Trinity.World
{
    public partial class BlackmarketTemplate
    {
        public int MarketId { get; set; }
        public int SellerNpc { get; set; }
        public int ItemEntry { get; set; }
        public int Quantity { get; set; }
        public long MinBid { get; set; }
        public int Duration { get; set; }
        public float Chance { get; set; }
        public string BonusListIds { get; set; }
    }
}
