namespace Delta.Trinity.World
{
    public partial class PlayerchoiceResponseRewardItem
    {
        public int ChoiceId { get; set; }
        public int ResponseId { get; set; }
        public int Index { get; set; }
        public int ItemId { get; set; }
        public string BonusListIds { get; set; }
        public int Quantity { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
