namespace Delta.Trinity.World
{
    public partial class PlayerchoiceResponseRewardCurrency
    {
        public int ChoiceId { get; set; }
        public int ResponseId { get; set; }
        public int Index { get; set; }
        public int CurrencyId { get; set; }
        public int Quantity { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
