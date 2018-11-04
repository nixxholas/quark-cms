namespace Delta.Trinity.World
{
    public partial class PlayerchoiceResponseLocale
    {
        public int ChoiceId { get; set; }
        public int ResponseId { get; set; }
        public string Locale { get; set; }
        public string Header { get; set; }
        public string Answer { get; set; }
        public string Description { get; set; }
        public string Confirmation { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
