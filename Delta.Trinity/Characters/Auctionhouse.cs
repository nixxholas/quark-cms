namespace Delta.Trinity.Characters
{
    public partial class Auctionhouse
    {
        public int Id { get; set; }
        public long Auctioneerguid { get; set; }
        public long Itemguid { get; set; }
        public long Itemowner { get; set; }
        public long Buyoutprice { get; set; }
        public int Time { get; set; }
        public long Buyguid { get; set; }
        public long Lastbid { get; set; }
        public long Startbid { get; set; }
        public long Deposit { get; set; }
    }
}
