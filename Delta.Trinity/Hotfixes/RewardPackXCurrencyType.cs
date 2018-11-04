namespace Delta.Trinity.Hotfixes
{
    public partial class RewardPackXCurrencyType
    {
        public int Id { get; set; }
        public int CurrencyTypeId { get; set; }
        public int Quantity { get; set; }
        public int RewardPackId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
